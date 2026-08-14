using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001499")]
public class EClientInfo
{
	[Token(Token = "0x200149A")]
	public enum ChannelType
	{
		[Token(Token = "0x4008EFF")]
		ChannelType_DEV,
		[Token(Token = "0x4008F00")]
		ChannelType_TRAIL,
		[Token(Token = "0x4008F01")]
		ChannelType_MAX,
		[Token(Token = "0x4008F02")]
		ChannelType_GP,
		[Token(Token = "0x4008F03")]
		ChannelType_HUAWEI,
		[Token(Token = "0x4008F04")]
		ChannelType_SAMSUNG,
		[Token(Token = "0x4008F05")]
		ChannelType_THIRDPARTY
	}

	[Token(Token = "0x200149B")]
	public enum Architecture
	{
		[Token(Token = "0x4008F07")]
		Architecture_None,
		[Token(Token = "0x4008F08")]
		Architecture_ARM,
		[Token(Token = "0x4008F09")]
		Architecture_ARM64,
		[Token(Token = "0x4008F0A")]
		Architecture_X86
	}

	[Token(Token = "0x6007B0C")]
	[Address(RVA = "0x309F290", Offset = "0x309F290", VA = "0x309F290")]
	public EClientInfo()
	{
	}
}
