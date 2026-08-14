using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200319D")]
public class NewPlayerTargetChaInfo
{
	[Token(Token = "0x4012DBF")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CMinLevel_003Ek__BackingField;

	[Token(Token = "0x4012DC0")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CMaxLevel_003Ek__BackingField;

	[Token(Token = "0x4012DC1")]
	[FieldOffset(Offset = "0x10")]
	private string _003CTargetHint_003Ek__BackingField;

	[Token(Token = "0x4012DC2")]
	[FieldOffset(Offset = "0x14")]
	private uint _003CAvatarID_003Ek__BackingField;

	[Token(Token = "0x170015F3")]
	public uint MinLevel
	{
		[Token(Token = "0x6014D9B")]
		[Address(RVA = "0x28B3F78", Offset = "0x28B3F78", VA = "0x28B3F78")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014D9C")]
		[Address(RVA = "0x28B3F80", Offset = "0x28B3F80", VA = "0x28B3F80")]
		private set
		{
		}
	}

	[Token(Token = "0x170015F4")]
	public uint MaxLevel
	{
		[Token(Token = "0x6014D9D")]
		[Address(RVA = "0x28B3F88", Offset = "0x28B3F88", VA = "0x28B3F88")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014D9E")]
		[Address(RVA = "0x28B3F90", Offset = "0x28B3F90", VA = "0x28B3F90")]
		private set
		{
		}
	}

	[Token(Token = "0x170015F5")]
	public string TargetHint
	{
		[Token(Token = "0x6014D9F")]
		[Address(RVA = "0x28B3F98", Offset = "0x28B3F98", VA = "0x28B3F98")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014DA0")]
		[Address(RVA = "0x28B3FA0", Offset = "0x28B3FA0", VA = "0x28B3FA0")]
		private set
		{
		}
	}

	[Token(Token = "0x170015F6")]
	public uint AvatarID
	{
		[Token(Token = "0x6014DA1")]
		[Address(RVA = "0x28B3FA8", Offset = "0x28B3FA8", VA = "0x28B3FA8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014DA2")]
		[Address(RVA = "0x28B3FB0", Offset = "0x28B3FB0", VA = "0x28B3FB0")]
		private set
		{
		}
	}

	[Token(Token = "0x6014D9A")]
	[Address(RVA = "0x28B3F70", Offset = "0x28B3F70", VA = "0x28B3F70")]
	public NewPlayerTargetChaInfo()
	{
	}

	[Token(Token = "0x6014DA3")]
	[Address(RVA = "0x28B3FB8", Offset = "0x28B3FB8", VA = "0x28B3FB8")]
	public static implicit operator NewPlayerTargetChaInfo(NewPlayerTargetData data)
	{
		return null;
	}
}
