using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001968")]
public class CSDigitalUniverseBStarCraftInfoRes
{
	[Token(Token = "0x2001969")]
	public class PlayerInfo
	{
		[Token(Token = "0x4009FB9")]
		[FieldOffset(Offset = "0x8")]
		public ulong account_id;

		[Token(Token = "0x4009FBA")]
		[FieldOffset(Offset = "0x10")]
		public uint progress;

		[Token(Token = "0x4009FBB")]
		[FieldOffset(Offset = "0x14")]
		public uint gravitational_value;

		[Token(Token = "0x4009FBC")]
		[FieldOffset(Offset = "0x18")]
		public ulong assistance_left_time;

		[Token(Token = "0x4009FBD")]
		[FieldOffset(Offset = "0x20")]
		public string nick_name;

		[Token(Token = "0x4009FBE")]
		[FieldOffset(Offset = "0x24")]
		public uint group_times;

		[Token(Token = "0x4009FBF")]
		[FieldOffset(Offset = "0x28")]
		public uint assistance_times;

		[Token(Token = "0x4009FC0")]
		[FieldOffset(Offset = "0x2C")]
		public uint head_pic;

		[Token(Token = "0x4009FC1")]
		[FieldOffset(Offset = "0x30")]
		public long upvote_timestamp;

		[Token(Token = "0x6007FC2")]
		[Address(RVA = "0x317F894", Offset = "0x317F894", VA = "0x317F894")]
		public PlayerInfo()
		{
		}
	}

	[Token(Token = "0x200196A")]
	public class AssistanceInfo
	{
		[Token(Token = "0x4009FC2")]
		[FieldOffset(Offset = "0x8")]
		public ulong account_id;

		[Token(Token = "0x4009FC3")]
		[FieldOffset(Offset = "0x10")]
		public string nick_name;

		[Token(Token = "0x4009FC4")]
		[FieldOffset(Offset = "0x14")]
		public uint head_pic;

		[Token(Token = "0x4009FC5")]
		[FieldOffset(Offset = "0x18")]
		public ulong timestamp;

		[Token(Token = "0x6007FC3")]
		[Address(RVA = "0x317F7F4", Offset = "0x317F7F4", VA = "0x317F7F4")]
		public AssistanceInfo()
		{
		}
	}

	[Token(Token = "0x4009FB2")]
	[FieldOffset(Offset = "0x8")]
	public List<PlayerInfo> player_infos;

	[Token(Token = "0x4009FB3")]
	[FieldOffset(Offset = "0xC")]
	public uint daily_assistance_times;

	[Token(Token = "0x4009FB4")]
	[FieldOffset(Offset = "0x10")]
	public List<AssistanceInfo> assistance_history;

	[Token(Token = "0x4009FB5")]
	[FieldOffset(Offset = "0x14")]
	public uint upvoted_times;

	[Token(Token = "0x4009FB6")]
	[FieldOffset(Offset = "0x18")]
	public string message_text;

	[Token(Token = "0x4009FB7")]
	[FieldOffset(Offset = "0x1C")]
	public uint[] claimed_target_list;

	[Token(Token = "0x4009FB8")]
	[FieldOffset(Offset = "0x20")]
	public ulong assist_timestamp;

	[Token(Token = "0x6007FC1")]
	[Address(RVA = "0x317F6EC", Offset = "0x317F6EC", VA = "0x317F6EC")]
	public CSDigitalUniverseBStarCraftInfoRes()
	{
	}
}
