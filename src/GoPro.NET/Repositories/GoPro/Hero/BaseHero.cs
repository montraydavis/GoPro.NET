using GoPro.NET.Models;

namespace GoPro.NET.Repositories.GoPro.Hero
{
    public abstract class BaseHero : IHero
    {
        const string _colorUri = "116";
        const string _sharpnessUri = "117";
        const string _resolutionUri = "2";
        const string _fpsUri = "3";
        const string _videoTimelapseInterval = "5";
        const string _loopingIntervalUri = "6";
        const string _isoMaxUri = "13";
        const string _isoMinUri = "102";
        const string _protuneUri = "114";
        const string _whiteBalanceUri = "115";
        const string _evCompUri = "118";
        const string _shutterUri = "19";
        const string _photoTimelapseIntervalUri = "30";
        const string _nightlapseShutterUri = "31";
        const string _nightlapseIntervalUri = "32";
        const string _nightlapseISOMaxUri = "37";
        const string _photoISOMinUri = "75";
        const string _burstISOMinUri = "76";
        const string _timelapseMultiProtuneUri = "114";
        const string _timelapseMultiWhiteBalanceUri = "115";
        const string _timelapseMultiColorUri = "116";
        const string _timelapseMultiSharpnessUri = "117";
        const string _timelapseMultiEVCompUri = "118";
        const string _timelapseQuickCaptureUri = "54";
        const string _autoOffUri = "59";
        const string _bitRateUri = "67";
        const string _audioProtuneUri = "79";
        const string _gpsProtuneUri = "83";
        const string _lensViewUri = "121";
        const string _bitRateHighuri = "124";
        const string _outputUri = "125";
        const string _megapixelsUri = "133";
        const string _durationUri = "157";
        const string _screenSaveFrontUri = "158";
        const string _screenSaveRearUri = "159";
        const string _bitrateHighStandardUri = "160";
        const string _defaultPresetUri = "161";
        const string _maxModLensEnableUri = "162";
        const string _maxLensModUri = "163";
        const string _mediaModekUri = "164";
        const string _horizonLockUri = "166";
        const string _hindsightUri = "167";
        const string _scheduleCapturUri = "168";
        const string _modsUri = "169";
        const string _inContextualSettingsUri = "170";



        protected HttpClient _httpClient;

        private async Task<bool> GetSetting(string uri, string endpoint)
        {
            var response = await this._httpClient.GetAsync($"gp/gpControl/setting/{uri}/{endpoint}");

            var body = (await response.Content.ReadAsStringAsync()).Replace("\n", "");

            return response.IsSuccessStatusCode;
        }

        public async virtual Task<bool> SetResolution(HeroResolution resolution) =>
            await GetSetting(_resolutionUri, Convert.ToInt32(resolution).ToString());

        public async virtual Task<bool> SetFPS(HeroFPS framesPerSecond) =>
            await GetSetting(_fpsUri, Convert.ToInt32(framesPerSecond).ToString());

        public async virtual Task<bool> SetVideoTimelapseInterval(HeroVideoTimelapseInterval videoTimelapseInterval) =>
            await GetSetting(_videoTimelapseInterval, Convert.ToInt32(videoTimelapseInterval).ToString());

        public async virtual Task<bool> SetLoopingInterval(HeroLoopInterval loopingInterval) =>
            await GetSetting(_loopingIntervalUri, Convert.ToInt32(loopingInterval).ToString());

        public async virtual Task<bool> SetISOMax(HeroISO iso) =>
            await GetSetting(_isoMaxUri, Convert.ToInt32(iso).ToString());

        public async virtual Task<bool> SetISOMin(HeroISO iso) =>
            await GetSetting(_isoMinUri, Convert.ToInt32(iso).ToString());

        public async virtual Task<bool> SetProtune(HeroBit protune) =>
            await GetSetting(_protuneUri, Convert.ToInt32(protune).ToString());

        public async virtual Task<bool> SetWhiteBalance(HeroWhiteBalance whiteBalance) =>
            await GetSetting(_whiteBalanceUri, Convert.ToInt32(whiteBalance).ToString());

        public async virtual Task<bool> SetColor(HeroColor color) =>
            await GetSetting(_colorUri, Convert.ToInt32(color).ToString());

        public async virtual Task<bool> SetSharpness(HeroSharpness sharpness) =>
            await GetSetting(_sharpnessUri, Convert.ToInt32(sharpness).ToString());

        public async virtual Task<bool> SetEVComp(HeroEVComp evComp) =>
            await GetSetting(_evCompUri, Convert.ToInt32(evComp).ToString());

        public async virtual Task<bool> SetShutter(HeroShutter shutter) =>
            await GetSetting(_shutterUri, Convert.ToInt32(shutter).ToString());

        public async virtual Task<bool> SetPhotoIntervalTimelapse(HeroPhotoTimelapseInterval photoTimelapseInterval) =>
            await GetSetting(_photoTimelapseIntervalUri, Convert.ToInt32(photoTimelapseInterval).ToString());

        public async virtual Task<bool> SetNightlapseShutter(HeroNightlapseShutter nightlapseShutter) =>
            await GetSetting(_nightlapseShutterUri, Convert.ToInt32(nightlapseShutter).ToString());

        public async virtual Task<bool> SetNightlapseInterval(HeroNightlapseShutter nightlapseShutter) =>
            await GetSetting(_nightlapseIntervalUri, Convert.ToInt32(nightlapseShutter).ToString());

        public async virtual Task<bool> SetNightlapseISOMax(HeroNightlapseISO iso) =>
            await GetSetting(_nightlapseISOMaxUri, Convert.ToInt32(iso).ToString());

        public async virtual Task<bool> SetPhotoISOMin(HeroISO iso) =>
            await GetSetting(_photoISOMinUri, Convert.ToInt32(iso).ToString());

        public async virtual Task<bool> SetBurstISOMin(HeroISO iso) =>
            await GetSetting(_burstISOMinUri, Convert.ToInt32(iso).ToString());

        public async virtual Task<bool> SetTimelapseMultiMode(HeroBit onOff) =>
            await GetSetting(_timelapseMultiProtuneUri, Convert.ToInt32(onOff).ToString());

        public async virtual Task<bool> SetTimelapseMultiWhiteBalance(HeroWhiteBalance whiteBalance) =>
            await GetSetting(_timelapseMultiWhiteBalanceUri, Convert.ToInt32(whiteBalance).ToString());

        public async virtual Task<bool> SetTimelapseMultiColor(HeroColor color) =>
            await GetSetting(_timelapseMultiColorUri, Convert.ToInt32(color).ToString());

        public async virtual Task<bool> SetTimelapseMultiSharpness(HeroSharpness sharpness) =>
            await GetSetting(_timelapseMultiSharpnessUri, Convert.ToInt32(sharpness).ToString());

        public async virtual Task<bool> SetTimelapseMultiEVComp(HeroEVComp evComp) =>
            await GetSetting(_timelapseMultiEVCompUri, Convert.ToInt32(evComp).ToString());

        public async virtual Task<bool> SetQuikCapture(HeroBit onOff) =>
            await GetSetting(_timelapseQuickCaptureUri, Convert.ToInt32(onOff).ToString());

        public async virtual Task<bool> SetAutoOff(HeroAutoOff autoOff) =>
            await GetSetting(_autoOffUri, Convert.ToInt32(autoOff).ToString());

        public async virtual Task<bool> SetBitrate(HeroBitrate bitRate) =>
            await GetSetting(_bitRateUri, Convert.ToInt32(bitRate).ToString());

        public async virtual Task<bool> SetAudioProtune(HeroBit onOff) =>
            await GetSetting(_audioProtuneUri, Convert.ToInt32(onOff).ToString());

        public async virtual Task<bool> SetGPSProtune(HeroBit onOff) =>
            await GetSetting(_gpsProtuneUri, Convert.ToInt32(onOff).ToString());

        public async virtual Task<bool> SetLensView(HeroLensView lensView) =>
            await GetSetting(_lensViewUri, Convert.ToInt32(lensView).ToString());

        public async virtual Task<bool> SetBitrateHigh(HeroBit onOff) =>
            await GetSetting(_bitRateHighuri, Convert.ToInt32(onOff).ToString());

        public async virtual Task<bool> SetOutput(HeroOutput output) =>
            await GetSetting(_outputUri, Convert.ToInt32(output).ToString());

        public async virtual Task<bool> SetMegapixels(HeroMegapixels megapixels) =>
            await GetSetting(_megapixelsUri, Convert.ToInt32(megapixels).ToString());

        public async virtual Task<bool> SetDuration(HeroDuration duration) =>
            await GetSetting(_durationUri, Convert.ToInt32(duration).ToString());

        public async virtual Task<bool> SetScreensaveFrontTime(HeroScreensaverFrontTime duration) =>
            await GetSetting(_screenSaveFrontUri, Convert.ToInt32(duration).ToString());

        public async virtual Task<bool> SetScreensaveRearTime(HeroScreensaverRearTime duration) =>
            await GetSetting(_screenSaveRearUri, Convert.ToInt32(duration).ToString());

        public async virtual Task<bool> SetBitrateHighStandard(HeroBitrate bitrate) =>
            await GetSetting(_bitrateHighStandardUri, Convert.ToInt32(bitrate).ToString());

        public async virtual Task<bool> SetDefaultPreset(HeroDefaultPreset defaultPreset) =>
            await GetSetting(_defaultPresetUri, Convert.ToInt32(defaultPreset).ToString());

        public async virtual Task<bool> SetMaxModLensOnOff(HeroBit onOff) =>
            await GetSetting(_maxModLensEnableUri, Convert.ToInt32(onOff).ToString());

        public async virtual Task<bool> SetMaxModLensEnable(HeroBit onOff) =>
            await GetSetting(_maxLensModUri, Convert.ToInt32(onOff).ToString());

        public async virtual Task<bool> SetMediaMod(HeroMediaMod mediaMod) =>
            await GetSetting(_mediaModekUri, Convert.ToInt32(mediaMod).ToString());

        public async virtual Task<bool> SetHorizonLockOnOff(HeroMediaMod onOff) =>
            await GetSetting(_horizonLockUri, Convert.ToInt32(onOff).ToString());

        public async virtual Task<bool> SetHindsightOnOff(HeroHindsight hindsight) =>
            await GetSetting(_hindsightUri, Convert.ToInt32(hindsight).ToString());

        public async virtual Task<bool> SetScheduleCaptureOff() =>
            await GetSetting(_scheduleCapturUri, Convert.ToInt32(HeroBit.Off).ToString());

        public async virtual Task<bool> SetModMediaLevels(HeroMediaModLevel mediaMod) =>
            await GetSetting(_modsUri, Convert.ToInt32(mediaMod).ToString());

        public async virtual Task<bool> SetContextualSettingsOnOff(HeroBit onOff) =>
            await GetSetting(_inContextualSettingsUri, Convert.ToInt32(onOff).ToString());



        public BaseHero(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
    }
}
