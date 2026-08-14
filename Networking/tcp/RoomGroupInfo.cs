using System.Collections.Generic;
using Il2CppDummyDll;

namespace tcp;

[Token(Token = "0x2001D67")]
public class RoomGroupInfo
{
	[Token(Token = "0x400B9C7")]
	[FieldOffset(Offset = "0x8")]
	private ulong _003Cid_003Ek__BackingField;

	[Token(Token = "0x400B9C8")]
	[FieldOffset(Offset = "0x10")]
	private string _003Cname_003Ek__BackingField;

	[Token(Token = "0x400B9C9")]
	[FieldOffset(Offset = "0x14")]
	private List<RoomPlayerInfo> _003Cmembers_003Ek__BackingField;

	[Token(Token = "0x400B9CA")]
	[FieldOffset(Offset = "0x18")]
	private string _003Cabbr_name_003Ek__BackingField;

	[Token(Token = "0x400B9CB")]
	[FieldOffset(Offset = "0x1C")]
	private uint _003Crank_003Ek__BackingField;

	[Token(Token = "0x400B9CC")]
	[FieldOffset(Offset = "0x20")]
	private uint _003Cscore_003Ek__BackingField;

	[Token(Token = "0x17000D07")]
	public ulong id
	{
		[Token(Token = "0x60089AD")]
		[Address(RVA = "0x435E038", Offset = "0x435E038", VA = "0x435E038")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x60089AE")]
		[Address(RVA = "0x435E040", Offset = "0x435E040", VA = "0x435E040")]
		set
		{
		}
	}

	[Token(Token = "0x17000D08")]
	public string name
	{
		[Token(Token = "0x60089AF")]
		[Address(RVA = "0x435E050", Offset = "0x435E050", VA = "0x435E050")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089B0")]
		[Address(RVA = "0x435E020", Offset = "0x435E020", VA = "0x435E020")]
		set
		{
		}
	}

	[Token(Token = "0x17000D09")]
	public List<RoomPlayerInfo> members
	{
		[Token(Token = "0x60089B1")]
		[Address(RVA = "0x435E058", Offset = "0x435E058", VA = "0x435E058")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089B2")]
		[Address(RVA = "0x435E028", Offset = "0x435E028", VA = "0x435E028")]
		private set
		{
		}
	}

	[Token(Token = "0x17000D0A")]
	public string abbr_name
	{
		[Token(Token = "0x60089B3")]
		[Address(RVA = "0x435E060", Offset = "0x435E060", VA = "0x435E060")]
		get
		{
			return null;
		}
		[Token(Token = "0x60089B4")]
		[Address(RVA = "0x435E030", Offset = "0x435E030", VA = "0x435E030")]
		set
		{
		}
	}

	[Token(Token = "0x17000D0B")]
	public uint rank
	{
		[Token(Token = "0x60089B5")]
		[Address(RVA = "0x435E068", Offset = "0x435E068", VA = "0x435E068")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60089B6")]
		[Address(RVA = "0x435E070", Offset = "0x435E070", VA = "0x435E070")]
		set
		{
		}
	}

	[Token(Token = "0x17000D0C")]
	public uint score
	{
		[Token(Token = "0x60089B7")]
		[Address(RVA = "0x435E078", Offset = "0x435E078", VA = "0x435E078")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60089B8")]
		[Address(RVA = "0x435E080", Offset = "0x435E080", VA = "0x435E080")]
		set
		{
		}
	}

	[Token(Token = "0x60089AC")]
	[Address(RVA = "0x435DF30", Offset = "0x435DF30", VA = "0x435DF30")]
	public RoomGroupInfo()
	{
	}
}
