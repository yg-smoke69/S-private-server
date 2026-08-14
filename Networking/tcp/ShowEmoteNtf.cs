using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001CEA")]
public class ShowEmoteNtf
{
	[Token(Token = "0x400B730")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Caccount_id_003Ek__BackingField;

	[Token(Token = "0x400B731")]
	[FieldOffset(Offset = "0x10")]
	private uint _003Cemote_id_003Ek__BackingField;

	[Token(Token = "0x400B732")]
	[FieldOffset(Offset = "0x14")]
	private List<AccountEmoteRandomID> _003Crandom_id_list_003Ek__BackingField;

	[Token(Token = "0x17000B97")]
	public ulong account_id
	{
		[Token(Token = "0x6008673")]
		[Address(RVA = "0x435F1E4", Offset = "0x435F1E4", VA = "0x435F1E4")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6008674")]
		[Address(RVA = "0x435F1EC", Offset = "0x435F1EC", VA = "0x435F1EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000B98")]
	public uint emote_id
	{
		[Token(Token = "0x6008675")]
		[Address(RVA = "0x435F1FC", Offset = "0x435F1FC", VA = "0x435F1FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6008676")]
		[Address(RVA = "0x435F204", Offset = "0x435F204", VA = "0x435F204")]
		set
		{
		}
	}

	[Token(Token = "0x17000B99")]
	public List<AccountEmoteRandomID> random_id_list
	{
		[Token(Token = "0x6008677")]
		[Address(RVA = "0x435F20C", Offset = "0x435F20C", VA = "0x435F20C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008678")]
		[Address(RVA = "0x435F1DC", Offset = "0x435F1DC", VA = "0x435F1DC")]
		private set
		{
		}
	}

	[Token(Token = "0x6008672")]
	[Address(RVA = "0x435F150", Offset = "0x435F150", VA = "0x435F150")]
	public ShowEmoteNtf()
	{
	}
}
