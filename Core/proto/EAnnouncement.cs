using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016C7")]
public class EAnnouncement
{
	[Token(Token = "0x20016C8")]
	public enum NavigationType
	{
		[Token(Token = "0x400972A")]
		NavigationType_NONE = 0,
		[Token(Token = "0x400972B")]
		NavigationType_PROFILE = 1,
		[Token(Token = "0x400972C")]
		NavigationType_GROUP = 2,
		[Token(Token = "0x400972D")]
		NavigationType_MALL = 3,
		[Token(Token = "0x400972E")]
		NavigationType_VAULT = 4,
		[Token(Token = "0x400972F")]
		NavigationType_CLAN = 5,
		[Token(Token = "0x4009730")]
		NavigationType_RECHARGE = 6,
		[Token(Token = "0x4009731")]
		NavigationType_ACTIVITY = 7,
		[Token(Token = "0x4009732")]
		NavigationType_FRIENDS = 8,
		[Token(Token = "0x4009733")]
		NavigationType_LOADOUTS = 9,
		[Token(Token = "0x4009734")]
		NavigationType_SETTING = 10,
		[Token(Token = "0x4009735")]
		NavigationType_TUTORIAL = 11,
		[Token(Token = "0x4009736")]
		NavigationType_MONTHCARD = 12,
		[Token(Token = "0x4009737")]
		NavigationType_AVATARPROFILE = 13,
		[Token(Token = "0x4009738")]
		NavigationType_ELITEPASS_MAIN = 114,
		[Token(Token = "0x4009739")]
		NavigationType_ELITEPASS_CHALLENGE = 214,
		[Token(Token = "0x400973A")]
		NavigationType_GACHA = 15,
		[Token(Token = "0x400973B")]
		NavigationType_INGAME_DROP = 23
	}

	[Token(Token = "0x20016C9")]
	public enum BroadcastSwitchType
	{
		[Token(Token = "0x400973D")]
		BroadcastSwitchType_NONE,
		[Token(Token = "0x400973E")]
		BroadcastSwitchType_MAIN,
		[Token(Token = "0x400973F")]
		BroadcastSwitchType_SILENCE
	}

	[Token(Token = "0x20016CA")]
	public enum Platform
	{
		[Token(Token = "0x4009741")]
		Platform_GENERAL,
		[Token(Token = "0x4009742")]
		Platform_IOS,
		[Token(Token = "0x4009743")]
		Platform_GOOGLEPLAY,
		[Token(Token = "0x4009744")]
		Platform_HUAWEI,
		[Token(Token = "0x4009745")]
		Platform_XIAOMI,
		[Token(Token = "0x4009746")]
		Platform_TRIAL
	}

	[Token(Token = "0x20016CB")]
	public enum Os
	{
		[Token(Token = "0x4009748")]
		Os_DEFAULT,
		[Token(Token = "0x4009749")]
		Os_IOS,
		[Token(Token = "0x400974A")]
		Os_ANDROID
	}

	[Token(Token = "0x20016CC")]
	public enum AndroidChannel
	{
		[Token(Token = "0x400974C")]
		AndroidChannel_DEFAULT,
		[Token(Token = "0x400974D")]
		AndroidChannel_GOOGLEPLAY,
		[Token(Token = "0x400974E")]
		AndroidChannel_HUAWEI,
		[Token(Token = "0x400974F")]
		AndroidChannel_XIAOMI,
		[Token(Token = "0x4009750")]
		AndroidChannel_TRIAL
	}

	[Token(Token = "0x20016CD")]
	public enum PhoneQuality
	{
		[Token(Token = "0x4009752")]
		PhoneQuality_DEFAULT,
		[Token(Token = "0x4009753")]
		PhoneQuality_WHITELIST,
		[Token(Token = "0x4009754")]
		PhoneQuality_HIGH,
		[Token(Token = "0x4009755")]
		PhoneQuality_MID,
		[Token(Token = "0x4009756")]
		PhoneQuality_LOW
	}

	[Token(Token = "0x20016CE")]
	public enum AboutMax
	{
		[Token(Token = "0x4009758")]
		AboutMax_ALL,
		[Token(Token = "0x4009759")]
		AboutMax_NOTMAX,
		[Token(Token = "0x400975A")]
		AboutMax_MAX,
		[Token(Token = "0x400975B")]
		AboutMax_FFI
	}

	[Token(Token = "0x6007D28")]
	[Address(RVA = "0x309F248", Offset = "0x309F248", VA = "0x309F248")]
	public EAnnouncement()
	{
	}
}
