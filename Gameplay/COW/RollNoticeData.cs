using System.Runtime.InteropServices;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EF6")]
public class RollNoticeData
{
	[Token(Token = "0x4011F13")]
	[FieldOffset(Offset = "0x8")]
	public string content;

	[Token(Token = "0x4011F14")]
	[FieldOffset(Offset = "0xC")]
	public EAnnouncement.NavigationType navType;

	[Token(Token = "0x4011F15")]
	[FieldOffset(Offset = "0x10")]
	public string gos_url;

	[Token(Token = "0x4011F16")]
	[FieldOffset(Offset = "0x14")]
	public string sub_go_pos;

	[Token(Token = "0x4011F17")]
	[FieldOffset(Offset = "0x18")]
	public bool use_embedded_browser;

	[Token(Token = "0x4011F18")]
	[FieldOffset(Offset = "0x1C")]
	public int go_pos;

	[Token(Token = "0x4011F19")]
	[FieldOffset(Offset = "0x20")]
	public EBroadCastType bc_type;

	[Token(Token = "0x4011F1A")]
	[FieldOffset(Offset = "0x24")]
	public object ext;

	[Token(Token = "0x6013A9F")]
	[Address(RVA = "0x240A8F8", Offset = "0x240A8F8", VA = "0x240A8F8")]
	public RollNoticeData(string ct, EAnnouncement.NavigationType t = EAnnouncement.NavigationType.NavigationType_NONE, EBroadCastType broadCastType = EBroadCastType.None, [Optional] object obj)
	{
	}

	[Token(Token = "0x6013AA0")]
	[Address(RVA = "0x240A9C8", Offset = "0x240A9C8", VA = "0x240A9C8")]
	public static implicit operator RollNoticeData(ScrollMarqueeDesc desc)
	{
		return null;
	}

	[Token(Token = "0x6013AA1")]
	[Address(RVA = "0x240AB74", Offset = "0x240AB74", VA = "0x240AB74")]
	public static implicit operator RollNoticeData(BroadcastMessage msg)
	{
		return null;
	}

	[Token(Token = "0x6013AA2")]
	[Address(RVA = "0x240AD24", Offset = "0x240AD24", VA = "0x240AD24")]
	public static implicit operator RollNoticeData(MessageInfo msg)
	{
		return null;
	}

	[Token(Token = "0x6013AA3")]
	[Address(RVA = "0x240AFC0", Offset = "0x240AFC0", VA = "0x240AFC0")]
	public bool IsSpecial()
	{
		return default(bool);
	}

	[Token(Token = "0x6013AA4")]
	[Address(RVA = "0x240B030", Offset = "0x240B030", VA = "0x240B030")]
	public bool IsGM()
	{
		return default(bool);
	}
}
