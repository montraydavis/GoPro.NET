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
            await GetSetting(_whiteBalanceUri, Convert.ToInt32(whiteBalance).ToString());

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



        public BaseHero(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
    }
}
