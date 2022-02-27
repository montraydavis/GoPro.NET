using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoPro.NET.Models;

namespace GoPro.NET.Repositories.GoPro.Hero
{
    internal interface IHero
    {
        Task<bool> SetColor(HeroColor color);
        Task<bool> SetSharpness(HeroSharpness sharpness);
        Task<bool> SetResolution(HeroResolution resolution);
        Task<bool> SetFPS(HeroFPS framesPerSecond);
        Task<bool> SetVideoTimelapseInterval(HeroVideoTimelapseInterval videoTimelapseInterval);
        Task<bool> SetLoopingInterval(HeroLoopInterval loopingInterval);
        Task<bool> SetISOMax(HeroISO iso);
        Task<bool> SetISOMin(HeroISO iso);
        Task<bool> SetProtune(HeroBit protune);
        Task<bool> SetWhiteBalance(HeroWhiteBalance whiteBalance);
        Task<bool> SetEVComp(HeroEVComp evComp);
        Task<bool> SetShutter(HeroShutter shutter);
        Task<bool> SetPhotoIntervalTimelapse(HeroPhotoTimelapseInterval photoTimelapseInterval);
        Task<bool> SetNightlapseShutter(HeroNightlapseShutter nightlapseShutter);
        Task<bool> SetNightlapseInterval(HeroNightlapseShutter nightlapseShutter);
        Task<bool> SetNightlapseISOMax(HeroNightlapseISO iso);
        Task<bool> SetPhotoISOMin(HeroISO iso);
        Task<bool> SetBurstISOMin(HeroISO iso);
        Task<bool> SetTimelapseMultiMode(HeroBit onOff);
        Task<bool> SetTimelapseMultiWhiteBalance(HeroWhiteBalance whiteBalance);
        Task<bool> SetTimelapseMultiColor(HeroColor color);
        Task<bool> SetTimelapseMultiSharpness(HeroSharpness sharpness);
        Task<bool> SetTimelapseMultiEVComp(HeroEVComp evComp);
        Task<bool> SetQuikCapture(HeroBit onOff);
        Task<bool> SetAutoOff(HeroAutoOff autoOff);
    }
}
