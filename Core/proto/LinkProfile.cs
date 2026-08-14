using System.Runtime.InteropServices;
using COW;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200168F")]
public class LinkProfile : _Attribute
{
	[Token(Token = "0x400966B")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x400966C")]
	[FieldOffset(Offset = "0xC")]
	public uint link_start_timestamp;

	[Token(Token = "0x400966D")]
	[FieldOffset(Offset = "0x10")]
	public uint link_end_timestamp;

	[Token(Token = "0x400966E")]
	[FieldOffset(Offset = "0x14")]
	public uint link_max;

	[Token(Token = "0x400966F")]
	[FieldOffset(Offset = "0x18")]
	public uint link_game_daily_max;

	[Token(Token = "0x4009670")]
	[FieldOffset(Offset = "0x1C")]
	public uint link_exchange_daily_max;

	[Token(Token = "0x4009671")]
	[FieldOffset(Offset = "0x20")]
	public uint game_link;

	[Token(Token = "0x4009672")]
	[FieldOffset(Offset = "0x24")]
	public uint exchange_link;

	[Token(Token = "0x4009673")]
	[FieldOffset(Offset = "0x28")]
	public uint link_show_timestamp;

	[Token(Token = "0x4009674")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_LinkExchangeDailyAmountMax;

	[Token(Token = "0x170009E1")]
	public uint LinkExchangeDailyAmountMax
	{
		[Token(Token = "0x6007CDA")]
		[Address(RVA = "0x30A52BC", Offset = "0x30A52BC", VA = "0x30A52BC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170009E2")]
	public uint Target
	{
		[Token(Token = "0x6007CDB")]
		[Address(RVA = "0x30A53AC", Offset = "0x30A53AC", VA = "0x30A53AC")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x170009E3")]
	public uint Progress
	{
		[Token(Token = "0x6007CDC")]
		[Address(RVA = "0x30A53B4", Offset = "0x30A53B4", VA = "0x30A53B4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x6007CD9")]
	[Address(RVA = "0x30A52B4", Offset = "0x30A52B4", VA = "0x30A52B4")]
	public LinkProfile()
	{
	}

	[Token(Token = "0x6007CDD")]
	[Address(RVA = "0x30A53C4", Offset = "0x30A53C4", VA = "0x30A53C4")]
	private uint GetAvatarTypeSortOrder()
	{
		return default(uint);
	}

	[Token(Token = "0x6007CDE")]
	[Address(RVA = "0x30A556C", Offset = "0x30A556C", VA = "0x30A556C")]
	public LinkProfile Clone()
	{
		return null;
	}

	[Token(Token = "0x6007CDF")]
	[Address(RVA = "0x30A56F4", Offset = "0x30A56F4", VA = "0x30A56F4")]
	public bool IsLinkStarted()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CE0")]
	[Address(RVA = "0x30A578C", Offset = "0x30A578C", VA = "0x30A578C")]
	public bool IsLinkExpired()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CE1")]
	[Address(RVA = "0x30A5824", Offset = "0x30A5824", VA = "0x30A5824")]
	public bool IsLinkShown()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CE2")]
	[Address(RVA = "0x30A58BC", Offset = "0x30A58BC", VA = "0x30A58BC")]
	public bool IsTargetReached()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CE3")]
	[Address(RVA = "0x30A58DC", Offset = "0x30A58DC", VA = "0x30A58DC")]
	public bool IsCurrentLinked()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CE4")]
	[Address(RVA = "0x30A59C8", Offset = "0x30A59C8", VA = "0x30A59C8")]
	public bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6007CE5")]
	[Address(RVA = "0x30A5C1C", Offset = "0x30A5C1C", VA = "0x30A5C1C")]
	public float GetProgressValue()
	{
		return default(float);
	}

	[Token(Token = "0x6007CE6")]
	[Address(RVA = "0x30A5D58", Offset = "0x30A5D58", VA = "0x30A5D58")]
	public string GetProgressFormatStr(string formatStr = "#0%")
	{
		return null;
	}

	[Token(Token = "0x6007CE7")]
	[Address(RVA = "0x30A53F0", Offset = "0x30A53F0", VA = "0x30A53F0")]
	public UIModelAvatarBase.EAvatarType GetAvatarType()
	{
		return default(UIModelAvatarBase.EAvatarType);
	}

	[Token(Token = "0x6007CE8")]
	[Address(RVA = "0x30A5D88", Offset = "0x30A5D88", VA = "0x30A5D88")]
	public string GetLinkProfileName()
	{
		return null;
	}

	[Token(Token = "0x6007CE9")]
	[Address(RVA = "0x30A606C", Offset = "0x30A606C", VA = "0x30A606C", Slot = "4")]
	public int CompareTo(object obj)
	{
		return default(int);
	}
}
