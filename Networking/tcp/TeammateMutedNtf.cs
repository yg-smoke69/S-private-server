using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CA2")]
public class TeammateMutedNtf
{
	[Token(Token = "0x400B556")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cmuted_account_id_003Ek__BackingField;

	[Token(Token = "0x400B557")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cmuted_nickname_003Ek__BackingField;

	[Token(Token = "0x400B558")]
	[FieldOffset(Offset = "0x18")]
	private long _003Cmute_mic_expire_time_003Ek__BackingField;

	[Token(Token = "0x400B559")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cbehavior_rule_id_003Ek__BackingField;

	[Token(Token = "0x17000A8A")]
	public ulong muted_account_id
	{
		[Token(Token = "0x6008425")]
		[Address(RVA = "0x435F6E8", Offset = "0x435F6E8", VA = "0x435F6E8")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008426")]
		[Address(RVA = "0x435F6F0", Offset = "0x435F6F0", VA = "0x435F6F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A8B")]
	public string muted_nickname
	{
		[Token(Token = "0x6008427")]
		[Address(RVA = "0x435F700", Offset = "0x435F700", VA = "0x435F700")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008428")]
		[Address(RVA = "0x435F6E0", Offset = "0x435F6E0", VA = "0x435F6E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A8C")]
	public long mute_mic_expire_time
	{
		[Token(Token = "0x6008429")]
		[Address(RVA = "0x435F708", Offset = "0x435F708", VA = "0x435F708")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600842A")]
		[Address(RVA = "0x435F710", Offset = "0x435F710", VA = "0x435F710")]
		set
		{
		}
	}

	[Token(Token = "0x17000A8D")]
	public uint behavior_rule_id
	{
		[Token(Token = "0x600842B")]
		[Address(RVA = "0x435F720", Offset = "0x435F720", VA = "0x435F720")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600842C")]
		[Address(RVA = "0x435F728", Offset = "0x435F728", VA = "0x435F728")]
		set
		{
		}
	}

	[Token(Token = "0x6008424")]
	[Address(RVA = "0x435F640", Offset = "0x435F640", VA = "0x435F640")]
	public TeammateMutedNtf()
	{
	}
}
