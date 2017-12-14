using System;
using System.Runtime.InteropServices;
using AWSPolly;
using CoreAnimation;
using CoreFoundation;
using CoreGraphics;
using CoreText;
using CoreVideo;
using Foundation;
using IOSurface;
using ImageIO;
using Metal;
using ObjCRuntime;
using OpenGLES;
using Security;
using UIKit;

namespace AWSPolly
{
    [Native]
    public enum AWSPollyErrorType : long
    {
        Unknown,
        InvalidLexicon,
        InvalidNextToken,
        InvalidSampleRate,
        InvalidSsml,
        LexiconNotFound,
        LexiconSizeExceeded,
        MarksNotSupportedForFormat,
        MaxLexemeLengthExceeded,
        MaxLexiconsNumberExceeded,
        ServiceFailure,
        SsmlMarksNotSupportedForTextType,
        TextLengthExceeded,
        UnsupportedPlsAlphabet,
        UnsupportedPlsLanguage
    }

    [Native]
    public enum AWSPollyGender : long
    {
        Unknown,
        Female,
        Male
    }

    [Native]
    public enum AWSPollyLanguageCode : long
    {
        Unknown,
        CyGB,
        DaDK,
        DeDE,
        EnAU,
        EnGB,
        EnGBWLS,
        EnIN,
        EnUS,
        EsES,
        EsUS,
        FrCA,
        FrFR,
        IsIS,
        ItIT,
        KoKR,
        JaJP,
        NbNO,
        NlNL,
        PlPL,
        PtBR,
        PtPT,
        RoRO,
        RuRU,
        SvSE,
        TrTR
    }

    [Native]
    public enum AWSPollyOutputFormat : long
    {
        Unknown,
        Json,
        Mp3,
        OggVorbis,
        Pcm
    }

    [Native]
    public enum AWSPollySpeechMarkType : long
    {
        Unknown,
        Sentence,
        Ssml,
        Viseme,
        Word
    }

    [Native]
    public enum AWSPollyTextType : long
    {
        Unknown,
        Ssml,
        Text
    }

    [Native]
    public enum AWSPollyVoiceId : long
    {
        Unknown,
        Geraint,
        Gwyneth,
        Mads,
        Naja,
        Hans,
        Marlene,
        Nicole,
        Russell,
        Amy,
        Brian,
        Emma,
        Raveena,
        Ivy,
        Joanna,
        Joey,
        Justin,
        Kendra,
        Kimberly,
        Matthew,
        Salli,
        Conchita,
        Enrique,
        Miguel,
        Penelope,
        Chantal,
        Celine,
        Mathieu,
        Dora,
        Karl,
        Carla,
        Giorgio,
        Mizuki,
        Liv,
        Lotte,
        Ruben,
        Ewa,
        Jacek,
        Jan,
        Maja,
        Ricardo,
        Vitoria,
        Cristiano,
        Ines,
        Carmen,
        Maxim,
        Tatyana,
        Astrid,
        Filiz,
        Vicki,
        Takumi,
        Seoyeon,
        Aditi
    }

    [Native]
    public enum AWSPollySynthesizeSpeechURLBuilderErrorType : long
    {
        ErrorUnknown,
        AccessKeyIsNil,
        SecretKeyIsNil,
        EndpointIsNil,
        InvalidExpiresDate,
        ErrorInvalidServiceType,
        CredentialProviderIsNil,
        InternalError
    }
}
