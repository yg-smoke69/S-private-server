using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003259")]
internal class PlayerData
{
	[Token(Token = "0x4013262")]
	[FieldOffset(Offset = "0x8")]
	public IHAAMHPPLMG id;

	[Token(Token = "0x4013263")]
	[FieldOffset(Offset = "0x20")]
	public ulong userId;

	[Token(Token = "0x4013264")]
	[FieldOffset(Offset = "0x28")]
	public byte gsTeamId;

	[Token(Token = "0x4013265")]
	[FieldOffset(Offset = "0x29")]
	public byte scTeamId;

	[Token(Token = "0x4013266")]
	[FieldOffset(Offset = "0x2A")]
	public byte scMemberId;

	[Token(Token = "0x4013267")]
	[FieldOffset(Offset = "0x2C")]
	public string nickname;

	[Token(Token = "0x4013268")]
	[FieldOffset(Offset = "0x30")]
	public string teamname;

	[Token(Token = "0x4013269")]
	[FieldOffset(Offset = "0x34")]
	public string teamnameabbr;

	[Token(Token = "0x401326A")]
	[FieldOffset(Offset = "0x38")]
	public uint headicon;

	[Token(Token = "0x401326B")]
	[FieldOffset(Offset = "0x3C")]
	public uint teamicon;

	[Token(Token = "0x401326C")]
	[FieldOffset(Offset = "0x40")]
	public uint killCount;

	[Token(Token = "0x401326D")]
	[FieldOffset(Offset = "0x44")]
	public List<uint> battleTags;

	[Token(Token = "0x401326E")]
	[FieldOffset(Offset = "0x48")]
	public uint damage;

	[Token(Token = "0x401326F")]
	[FieldOffset(Offset = "0x4C")]
	public bool isDead;

	[Token(Token = "0x4013270")]
	[FieldOffset(Offset = "0x50")]
	public string area;

	[Token(Token = "0x4013271")]
	[FieldOffset(Offset = "0x54")]
	public uint deadCount;

	[Token(Token = "0x4013272")]
	[FieldOffset(Offset = "0x58")]
	public uint assistCount;

	[Token(Token = "0x4013273")]
	[FieldOffset(Offset = "0x5C")]
	public uint survival_time;

	[Token(Token = "0x4013274")]
	[FieldOffset(Offset = "0x60")]
	public uint avatarID;

	[Token(Token = "0x4013275")]
	[FieldOffset(Offset = "0x64")]
	public List<uint> clothes;

	[Token(Token = "0x4013276")]
	[FieldOffset(Offset = "0x68")]
	public uint skinColor;

	[Token(Token = "0x4013277")]
	[FieldOffset(Offset = "0x6C")]
	public string ClanName;

	[Token(Token = "0x4013278")]
	[FieldOffset(Offset = "0x70")]
	public uint ClanBadgeID;

	[Token(Token = "0x4013279")]
	[FieldOffset(Offset = "0x74")]
	public uint showWeaponId;

	[Token(Token = "0x401327A")]
	[FieldOffset(Offset = "0x78")]
	public uint transformerId;

	[Token(Token = "0x401327B")]
	[FieldOffset(Offset = "0x7C")]
	public uint groupAnimId;

	[Token(Token = "0x401327C")]
	[FieldOffset(Offset = "0x80")]
	public uint BannerId;

	[Token(Token = "0x401327D")]
	[FieldOffset(Offset = "0x84")]
	public int TeamIndex;

	[Token(Token = "0x401327E")]
	[FieldOffset(Offset = "0x88")]
	public Vector3 lastPosition;

	[Token(Token = "0x401327F")]
	[FieldOffset(Offset = "0x94")]
	public Vector3 lastForward;

	[Token(Token = "0x4013280")]
	[FieldOffset(Offset = "0xA0")]
	public Dictionary<uint, int> itemDic;

	[Token(Token = "0x4013281")]
	[FieldOffset(Offset = "0xA4")]
	public Player player;

	[Token(Token = "0x4013282")]
	[FieldOffset(Offset = "0xA8")]
	public float headScale;

	[Token(Token = "0x4013283")]
	[FieldOffset(Offset = "0xAC")]
	public uint headAvatarID;

	[Token(Token = "0x4013284")]
	[FieldOffset(Offset = "0xB0")]
	public int score;

	[Token(Token = "0x4013285")]
	[FieldOffset(Offset = "0xB4")]
	public int factionId;

	[Token(Token = "0x4013286")]
	[FieldOffset(Offset = "0xB8")]
	public uint likeCount;

	[Token(Token = "0x4013287")]
	[FieldOffset(Offset = "0xBC")]
	public uint rank;

	[Token(Token = "0x4013288")]
	[FieldOffset(Offset = "0xC0")]
	public uint role;

	[Token(Token = "0x4013289")]
	[FieldOffset(Offset = "0xC4")]
	public bool isSamoAI;

	[Token(Token = "0x60153CB")]
	[Address(RVA = "0x1C086AC", Offset = "0x1C086AC", VA = "0x1C086AC")]
	public PlayerData()
	{
	}

	[Token(Token = "0x60153CC")]
	[Address(RVA = "0x1C08738", Offset = "0x1C08738", VA = "0x1C08738")]
	public static implicit operator BaseProfileInfo(PlayerData playerDataInfo)
	{
		return null;
	}

	[Token(Token = "0x60153CD")]
	[Address(RVA = "0x1C088A4", Offset = "0x1C088A4", VA = "0x1C088A4")]
	public PlayerData Clone()
	{
		return null;
	}
}
