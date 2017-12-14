using System;
using Foundation;
using ObjCRuntime;

namespace AWSPolly
{
    // @interface AWSPollyDeleteLexiconInput
    interface AWSPollyDeleteLexiconInput
    {
        // @property (nonatomic, strong) NSString * _Nullable name;
        [NullAllowed, Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }
    }

    // @interface AWSPollyDeleteLexiconOutput
    interface AWSPollyDeleteLexiconOutput
    {
    }

    // @interface AWSPollyDescribeVoicesInput
    interface AWSPollyDescribeVoicesInput
    {
        // @property (assign, nonatomic) AWSPollyLanguageCode languageCode;
        [Export("languageCode", ArgumentSemantic.Assign)]
        AWSPollyLanguageCode LanguageCode { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable nextToken;
        [NullAllowed, Export("nextToken", ArgumentSemantic.Strong)]
        string NextToken { get; set; }
    }

    // @interface AWSPollyDescribeVoicesOutput
    interface AWSPollyDescribeVoicesOutput
    {
        // @property (nonatomic, strong) NSString * _Nullable nextToken;
        [NullAllowed, Export("nextToken", ArgumentSemantic.Strong)]
        string NextToken { get; set; }

        // @property (nonatomic, strong) NSArray<AWSPollyVoice *> * _Nullable voices;
        [NullAllowed, Export("voices", ArgumentSemantic.Strong)]
        AWSPollyVoice[] Voices { get; set; }
    }

    // @interface AWSPollyGetLexiconInput
    interface AWSPollyGetLexiconInput
    {
        // @property (nonatomic, strong) NSString * _Nullable name;
        [NullAllowed, Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }
    }

    // @interface AWSPollyGetLexiconOutput
    interface AWSPollyGetLexiconOutput
    {
        // @property (nonatomic, strong) AWSPollyLexicon * _Nullable lexicon;
        [NullAllowed, Export("lexicon", ArgumentSemantic.Strong)]
        AWSPollyLexicon Lexicon { get; set; }

        // @property (nonatomic, strong) AWSPollyLexiconAttributes * _Nullable lexiconAttributes;
        [NullAllowed, Export("lexiconAttributes", ArgumentSemantic.Strong)]
        AWSPollyLexiconAttributes LexiconAttributes { get; set; }
    }

    // @interface AWSPollyLexicon
    interface AWSPollyLexicon
    {
        // @property (nonatomic, strong) NSString * _Nullable content;
        [NullAllowed, Export("content", ArgumentSemantic.Strong)]
        string Content { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable name;
        [NullAllowed, Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }
    }

    // @interface AWSPollyLexiconAttributes
    interface AWSPollyLexiconAttributes
    {
        // @property (nonatomic, strong) NSString * _Nullable alphabet;
        [NullAllowed, Export("alphabet", ArgumentSemantic.Strong)]
        string Alphabet { get; set; }

        // @property (assign, nonatomic) AWSPollyLanguageCode languageCode;
        [Export("languageCode", ArgumentSemantic.Assign)]
        AWSPollyLanguageCode LanguageCode { get; set; }

        // @property (nonatomic, strong) NSDate * _Nullable lastModified;
        [NullAllowed, Export("lastModified", ArgumentSemantic.Strong)]
        NSDate LastModified { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable lexemesCount;
        [NullAllowed, Export("lexemesCount", ArgumentSemantic.Strong)]
        NSNumber LexemesCount { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable lexiconArn;
        [NullAllowed, Export("lexiconArn", ArgumentSemantic.Strong)]
        string LexiconArn { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable size;
        [NullAllowed, Export("size", ArgumentSemantic.Strong)]
        NSNumber Size { get; set; }
    }

    // @interface AWSPollyLexiconDescription
    interface AWSPollyLexiconDescription
    {
        // @property (nonatomic, strong) AWSPollyLexiconAttributes * _Nullable attributes;
        [NullAllowed, Export("attributes", ArgumentSemantic.Strong)]
        AWSPollyLexiconAttributes Attributes { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable name;
        [NullAllowed, Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }
    }

    // @interface AWSPollyListLexiconsInput
    interface AWSPollyListLexiconsInput
    {
        // @property (nonatomic, strong) NSString * _Nullable nextToken;
        [NullAllowed, Export("nextToken", ArgumentSemantic.Strong)]
        string NextToken { get; set; }
    }

    // @interface AWSPollyListLexiconsOutput
    interface AWSPollyListLexiconsOutput
    {
        // @property (nonatomic, strong) NSArray<AWSPollyLexiconDescription *> * _Nullable lexicons;
        [NullAllowed, Export("lexicons", ArgumentSemantic.Strong)]
        AWSPollyLexiconDescription[] Lexicons { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable nextToken;
        [NullAllowed, Export("nextToken", ArgumentSemantic.Strong)]
        string NextToken { get; set; }
    }

    // @interface AWSPollyPutLexiconInput
    interface AWSPollyPutLexiconInput
    {
        // @property (nonatomic, strong) NSString * _Nullable content;
        [NullAllowed, Export("content", ArgumentSemantic.Strong)]
        string Content { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable name;
        [NullAllowed, Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }
    }

    // @interface AWSPollyPutLexiconOutput
    interface AWSPollyPutLexiconOutput
    {
    }

    // @interface AWSPollySynthesizeSpeechInput
    interface AWSPollySynthesizeSpeechInput
    {
        // @property (nonatomic, strong) NSArray<NSString *> * _Nullable lexiconNames;
        [NullAllowed, Export("lexiconNames", ArgumentSemantic.Strong)]
        string[] LexiconNames { get; set; }

        // @property (assign, nonatomic) AWSPollyOutputFormat outputFormat;
        [Export("outputFormat", ArgumentSemantic.Assign)]
        AWSPollyOutputFormat OutputFormat { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable sampleRate;
        [NullAllowed, Export("sampleRate", ArgumentSemantic.Strong)]
        string SampleRate { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * _Nullable speechMarkTypes;
        [NullAllowed, Export("speechMarkTypes", ArgumentSemantic.Strong)]
        string[] SpeechMarkTypes { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable text;
        [NullAllowed, Export("text", ArgumentSemantic.Strong)]
        string Text { get; set; }

        // @property (assign, nonatomic) AWSPollyTextType textType;
        [Export("textType", ArgumentSemantic.Assign)]
        AWSPollyTextType TextType { get; set; }

        // @property (assign, nonatomic) AWSPollyVoiceId voiceId;
        [Export("voiceId", ArgumentSemantic.Assign)]
        AWSPollyVoiceId VoiceId { get; set; }
    }

    // @interface AWSPollySynthesizeSpeechOutput
    interface AWSPollySynthesizeSpeechOutput
    {
        // @property (nonatomic, strong) NSData * _Nullable audioStream;
        [NullAllowed, Export("audioStream", ArgumentSemantic.Strong)]
        NSData AudioStream { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable contentType;
        [NullAllowed, Export("contentType", ArgumentSemantic.Strong)]
        string ContentType { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable requestCharacters;
        [NullAllowed, Export("requestCharacters", ArgumentSemantic.Strong)]
        NSNumber RequestCharacters { get; set; }
    }

    // @interface AWSPollyVoice
    interface AWSPollyVoice
    {
        // @property (assign, nonatomic) AWSPollyGender gender;
        [Export("gender", ArgumentSemantic.Assign)]
        AWSPollyGender Gender { get; set; }

        // @property (assign, nonatomic) AWSPollyVoiceId identifier;
        [Export("identifier", ArgumentSemantic.Assign)]
        AWSPollyVoiceId Identifier { get; set; }

        // @property (assign, nonatomic) AWSPollyLanguageCode languageCode;
        [Export("languageCode", ArgumentSemantic.Assign)]
        AWSPollyLanguageCode LanguageCode { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable languageName;
        [NullAllowed, Export("languageName", ArgumentSemantic.Strong)]
        string LanguageName { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable name;
        [NullAllowed, Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }
    }

    // @interface AWSPollyResources : NSObject
    [BaseType(typeof(NSObject))]
    interface AWSPollyResources
    {
        // +(instancetype)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        AWSPollyResources SharedInstance();

        // -(NSDictionary *)JSONObject;
        [Export("JSONObject")]
        NSDictionary JSONObject { get; }
    }

    // @interface AWSPolly
    interface AWSPolly
    {
        // @property (readonly, nonatomic, strong) int * _Nonnull configuration;
        [Export("configuration", ArgumentSemantic.Strong)]
        unsafe int* Configuration { get; }

        // +(instancetype _Nonnull)defaultPolly;
        [Static]
        [Export("defaultPolly")]
        AWSPolly DefaultPolly();

        // +(void)registerPollyWithConfiguration:(id)configuration forKey:(NSString * _Nonnull)key;
        [Static]
        [Export("registerPollyWithConfiguration:forKey:")]
        void RegisterPollyWithConfiguration(NSObject configuration, string key);

        // +(instancetype _Nonnull)PollyForKey:(NSString * _Nonnull)key;
        [Static]
        [Export("PollyForKey:")]
        AWSPolly PollyForKey(string key);

        // +(void)removePollyForKey:(NSString * _Nonnull)key;
        [Static]
        [Export("removePollyForKey:")]
        void RemovePollyForKey(string key);

        // -(id)deleteLexicon:(AWSPollyDeleteLexiconInput * _Nonnull)request;
        [Export("deleteLexicon:")]
        NSObject DeleteLexicon(AWSPollyDeleteLexiconInput request);

        // -(void)deleteLexicon:(AWSPollyDeleteLexiconInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSPollyDeleteLexiconOutput * _Nullable, NSError * _Nullable))completionHandler;
        [Export("deleteLexicon:completionHandler:")]
        void DeleteLexicon(AWSPollyDeleteLexiconInput request, [NullAllowed] Action<AWSPollyDeleteLexiconOutput, NSError> completionHandler);

        // -(id)describeVoices:(AWSPollyDescribeVoicesInput * _Nonnull)request;
        [Export("describeVoices:")]
        NSObject DescribeVoices(AWSPollyDescribeVoicesInput request);

        // -(void)describeVoices:(AWSPollyDescribeVoicesInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSPollyDescribeVoicesOutput * _Nullable, NSError * _Nullable))completionHandler;
        [Export("describeVoices:completionHandler:")]
        void DescribeVoices(AWSPollyDescribeVoicesInput request, [NullAllowed] Action<AWSPollyDescribeVoicesOutput, NSError> completionHandler);

        // -(id)getLexicon:(AWSPollyGetLexiconInput * _Nonnull)request;
        [Export("getLexicon:")]
        NSObject GetLexicon(AWSPollyGetLexiconInput request);

        // -(void)getLexicon:(AWSPollyGetLexiconInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSPollyGetLexiconOutput * _Nullable, NSError * _Nullable))completionHandler;
        [Export("getLexicon:completionHandler:")]
        void GetLexicon(AWSPollyGetLexiconInput request, [NullAllowed] Action<AWSPollyGetLexiconOutput, NSError> completionHandler);

        // -(id)listLexicons:(AWSPollyListLexiconsInput * _Nonnull)request;
        [Export("listLexicons:")]
        NSObject ListLexicons(AWSPollyListLexiconsInput request);

        // -(void)listLexicons:(AWSPollyListLexiconsInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSPollyListLexiconsOutput * _Nullable, NSError * _Nullable))completionHandler;
        [Export("listLexicons:completionHandler:")]
        void ListLexicons(AWSPollyListLexiconsInput request, [NullAllowed] Action<AWSPollyListLexiconsOutput, NSError> completionHandler);

        // -(id)putLexicon:(AWSPollyPutLexiconInput * _Nonnull)request;
        [Export("putLexicon:")]
        NSObject PutLexicon(AWSPollyPutLexiconInput request);

        // -(void)putLexicon:(AWSPollyPutLexiconInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSPollyPutLexiconOutput * _Nullable, NSError * _Nullable))completionHandler;
        [Export("putLexicon:completionHandler:")]
        void PutLexicon(AWSPollyPutLexiconInput request, [NullAllowed] Action<AWSPollyPutLexiconOutput, NSError> completionHandler);

        // -(id)synthesizeSpeech:(AWSPollySynthesizeSpeechInput * _Nonnull)request;
        [Export("synthesizeSpeech:")]
        NSObject SynthesizeSpeech(AWSPollySynthesizeSpeechInput request);

        // -(void)synthesizeSpeech:(AWSPollySynthesizeSpeechInput * _Nonnull)request completionHandler:(void (^ _Nullable)(AWSPollySynthesizeSpeechOutput * _Nullable, NSError * _Nullable))completionHandler;
        [Export("synthesizeSpeech:completionHandler:")]
        void SynthesizeSpeech(AWSPollySynthesizeSpeechInput request, [NullAllowed] Action<AWSPollySynthesizeSpeechOutput, NSError> completionHandler);
    }

    [Static]
    partial interface AWSPollySynthesizeSpeechURLBuilderConstants
    {
        // extern NSString *const _Nonnull AWSPollySynthesizeSpeechURLBuilderErrorDomain;
        [Field("AWSPollySynthesizeSpeechURLBuilderErrorDomain", "__Internal")]
        NSString ErrorDomain { get; }
    }

    // @interface AWSPollySynthesizeSpeechURLBuilderRequest : NSObject
    [BaseType(typeof(NSObject))]
    interface AWSPollySynthesizeSpeechURLBuilderRequest
    {
        // @property (nonatomic, strong) NSArray<NSString *> * _Nullable lexiconNames;
        [NullAllowed, Export("lexiconNames", ArgumentSemantic.Strong)]
        string[] LexiconNames { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * _Nullable speechMarkTypes;
        [NullAllowed, Export("speechMarkTypes", ArgumentSemantic.Strong)]
        string[] SpeechMarkTypes { get; set; }

        // @property (assign, nonatomic) AWSPollyOutputFormat outputFormat;
        [Export("outputFormat", ArgumentSemantic.Assign)]
        AWSPollyOutputFormat OutputFormat { get; set; }

        // @property (nonatomic, strong) NSString * _Nullable sampleRate;
        [NullAllowed, Export("sampleRate", ArgumentSemantic.Strong)]
        string SampleRate { get; set; }

        // @property (nonatomic, strong) NSString * _Nonnull text;
        [Export("text", ArgumentSemantic.Strong)]
        string Text { get; set; }

        // @property (assign, nonatomic) AWSPollyTextType textType;
        [Export("textType", ArgumentSemantic.Assign)]
        AWSPollyTextType TextType { get; set; }

        // @property (assign, nonatomic) AWSPollyVoiceId voiceId;
        [Export("voiceId", ArgumentSemantic.Assign)]
        AWSPollyVoiceId VoiceId { get; set; }

        // @property (nonatomic, strong) NSDate * _Nonnull expires;
        [Export("expires", ArgumentSemantic.Strong)]
        NSDate Expires { get; set; }
    }

    // @interface AWSPollySynthesizeSpeechURLBuilder : NSObject
    [BaseType(typeof(NSObject))]
    interface AWSPollySynthesizeSpeechURLBuilder
    {
        // +(instancetype _Nonnull)defaultPollySynthesizeSpeechURLBuilder;
        [Static]
        [Export("defaultPollySynthesizeSpeechURLBuilder")]
        AWSPollySynthesizeSpeechURLBuilder DefaultPollySynthesizeSpeechURLBuilder();

        // +(void)registerPollySynthesizeSpeechURLBuilder:(id)configuration forKey:(NSString * _Nonnull)key;
        [Static]
        [Export("registerPollySynthesizeSpeechURLBuilder:forKey:")]
        void RegisterPollySynthesizeSpeechURLBuilder(NSObject configuration, string key);

        // +(instancetype _Nonnull)PollySynthesizeSpeechURLBuilderForKey:(NSString * _Nonnull)key;
        [Static]
        [Export("PollySynthesizeSpeechURLBuilderForKey:")]
        AWSPollySynthesizeSpeechURLBuilder PollySynthesizeSpeechURLBuilderForKey(string key);

        // +(void)removePollySynthesizeSpeechURLBuilderForKey:(NSString * _Nonnull)key;
        [Static]
        [Export("removePollySynthesizeSpeechURLBuilderForKey:")]
        void RemovePollySynthesizeSpeechURLBuilderForKey(string key);

        // -(id)getPreSignedURL:(AWSPollySynthesizeSpeechURLBuilderRequest * _Nonnull)getPreSignedURLRequest;
        [Export("getPreSignedURL:")]
        NSObject GetPreSignedURL(AWSPollySynthesizeSpeechURLBuilderRequest getPreSignedURLRequest);
    }
}
