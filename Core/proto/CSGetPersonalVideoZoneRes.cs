using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001767")]
public class CSGetPersonalVideoZoneRes
{
	[Token(Token = "0x4009A2E")]
	[FieldOffset(Offset = "0x8")]
	public string nickname;

	[Token(Token = "0x4009A2F")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.GenderType sex;

	[Token(Token = "0x4009A30")]
	[FieldOffset(Offset = "0x10")]
	public uint fan_count;

	[Token(Token = "0x4009A31")]
	[FieldOffset(Offset = "0x14")]
	public uint head_pic;

	[Token(Token = "0x4009A32")]
	[FieldOffset(Offset = "0x18")]
	public ELive.FollowerType follower_type;

	[Token(Token = "0x4009A33")]
	[FieldOffset(Offset = "0x1C")]
	public List<VideoDetail> video_list;

	[Token(Token = "0x6007DC1")]
	[Address(RVA = "0x3188568", Offset = "0x3188568", VA = "0x3188568")]
	public CSGetPersonalVideoZoneRes()
	{
	}
}
