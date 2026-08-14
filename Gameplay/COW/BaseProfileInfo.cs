using System.Collections.Generic;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002D37")]
public class BaseProfileInfo
{
	[Token(Token = "0x4011477")]
	[FieldOffset(Offset = "0x8")]
	public ulong AccountID;

	[Token(Token = "0x4011478")]
	[FieldOffset(Offset = "0x10")]
	public string Region;

	[Token(Token = "0x4011479")]
	[FieldOffset(Offset = "0x14")]
	public uint Level;

	[Token(Token = "0x401147A")]
	[FieldOffset(Offset = "0x18")]
	public string NickName;

	[Token(Token = "0x401147B")]
	[FieldOffset(Offset = "0x1C")]
	public string OnlineState;

	[Token(Token = "0x401147C")]
	[FieldOffset(Offset = "0x20")]
	public string PortraitUrl;

	[Token(Token = "0x401147D")]
	[FieldOffset(Offset = "0x24")]
	public string PlatformIcon;

	[Token(Token = "0x401147E")]
	[FieldOffset(Offset = "0x28")]
	public string ExternalName;

	[Token(Token = "0x401147F")]
	[FieldOffset(Offset = "0x2C")]
	public string GenderIcon;

	[Token(Token = "0x4011480")]
	[FieldOffset(Offset = "0x30")]
	public string ClanName;

	[Token(Token = "0x4011481")]
	[FieldOffset(Offset = "0x34")]
	public uint ClanBadgeID;

	[Token(Token = "0x4011482")]
	[FieldOffset(Offset = "0x38")]
	public uint Banner;

	[Token(Token = "0x4011483")]
	[FieldOffset(Offset = "0x3C")]
	public uint HeadPic;

	[Token(Token = "0x4011484")]
	[FieldOffset(Offset = "0x40")]
	public int Rank;

	[Token(Token = "0x4011485")]
	[FieldOffset(Offset = "0x44")]
	public int RankPoint;

	[Token(Token = "0x4011486")]
	[FieldOffset(Offset = "0x48")]
	public int PeakRankPos;

	[Token(Token = "0x4011487")]
	[FieldOffset(Offset = "0x4C")]
	public int CSRank;

	[Token(Token = "0x4011488")]
	[FieldOffset(Offset = "0x50")]
	public int CSRankPoint;

	[Token(Token = "0x4011489")]
	[FieldOffset(Offset = "0x54")]
	public int CSPeakRankPos;

	[Token(Token = "0x401148A")]
	[FieldOffset(Offset = "0x58")]
	public bool is_cs_ranking_ban;

	[Token(Token = "0x401148B")]
	[FieldOffset(Offset = "0x60")]
	public long Update_time;

	[Token(Token = "0x401148C")]
	[FieldOffset(Offset = "0x68")]
	public uint skinColor;

	[Token(Token = "0x401148D")]
	[FieldOffset(Offset = "0x6C")]
	public uint AvatarID;

	[Token(Token = "0x401148E")]
	[FieldOffset(Offset = "0x70")]
	public List<uint> cloth;

	[Token(Token = "0x401148F")]
	[FieldOffset(Offset = "0x74")]
	public proto.EPresence.AccountPresence OnlineStatus;

	[Token(Token = "0x4011490")]
	[FieldOffset(Offset = "0x78")]
	public uint LootBox;

	[Token(Token = "0x4011491")]
	[FieldOffset(Offset = "0x7C")]
	public uint BackPack;

	[Token(Token = "0x4011492")]
	[FieldOffset(Offset = "0x80")]
	public uint Parachute;

	[Token(Token = "0x4011493")]
	[FieldOffset(Offset = "0x84")]
	public uint Skyboard;

	[Token(Token = "0x4011494")]
	[FieldOffset(Offset = "0x88")]
	public uint Flight;

	[Token(Token = "0x4011495")]
	[FieldOffset(Offset = "0x8C")]
	public uint Pin;

	[Token(Token = "0x4011496")]
	[FieldOffset(Offset = "0x90")]
	public uint GroupAnim;

	[Token(Token = "0x4011497")]
	[FieldOffset(Offset = "0x94")]
	public uint Music;

	[Token(Token = "0x4011498")]
	[FieldOffset(Offset = "0x98")]
	public Dictionary<uint, uint> Weapons;

	[Token(Token = "0x4011499")]
	[FieldOffset(Offset = "0x9C")]
	public Dictionary<uint, uint> VehicleSkins;

	[Token(Token = "0x401149A")]
	[FieldOffset(Offset = "0xA0")]
	public Dictionary<uint, uint> EmoteSlots;

	[Token(Token = "0x401149B")]
	[FieldOffset(Offset = "0xA4")]
	public Dictionary<uint, uint> Shows;

	[Token(Token = "0x401149C")]
	[FieldOffset(Offset = "0xA8")]
	public bool HasElitePass;

	[Token(Token = "0x401149D")]
	[FieldOffset(Offset = "0xAC")]
	public uint EPBadgeId;

	[Token(Token = "0x401149E")]
	[FieldOffset(Offset = "0xB0")]
	public uint EPBadgeCount;

	[Token(Token = "0x401149F")]
	[FieldOffset(Offset = "0xB4")]
	public bool ShowCallsignRank;

	[Token(Token = "0x40114A0")]
	[FieldOffset(Offset = "0xB8")]
	public long LastLoginAt;

	[Token(Token = "0x40114A1")]
	[FieldOffset(Offset = "0xC0")]
	public uint Role;

	[Token(Token = "0x40114A2")]
	[FieldOffset(Offset = "0xC8")]
	public ulong GroupId;

	[Token(Token = "0x40114A3")]
	[FieldOffset(Offset = "0xD0")]
	public uint TrainingTokenCnt;

	[Token(Token = "0x40114A4")]
	[FieldOffset(Offset = "0xD4")]
	public uint gamebagid;

	[Token(Token = "0x40114A5")]
	[FieldOffset(Offset = "0xD8")]
	public uint hostTeamIndex;

	[Token(Token = "0x6012EA1")]
	[Address(RVA = "0x2E61E5C", Offset = "0x2E61E5C", VA = "0x2E61E5C")]
	public BaseProfileInfo(LoginRes loginInfo)
	{
	}

	[Token(Token = "0x6012EA2")]
	[Address(RVA = "0x2E620EC", Offset = "0x2E620EC", VA = "0x2E620EC")]
	public BaseProfileInfo(UGCPlayerStats data)
	{
	}

	[Token(Token = "0x6012EA3")]
	[Address(RVA = "0x2E62360", Offset = "0x2E62360", VA = "0x2E62360")]
	public BaseProfileInfo(TeammateStats data)
	{
	}

	[Token(Token = "0x6012EA4")]
	[Address(RVA = "0x2E62680", Offset = "0x2E62680", VA = "0x2E62680")]
	public BaseProfileInfo(MatchStats data)
	{
	}

	[Token(Token = "0x6012EA5")]
	[Address(RVA = "0x2E62930", Offset = "0x2E62930", VA = "0x2E62930")]
	public BaseProfileInfo()
	{
	}

	[Token(Token = "0x6012EA6")]
	[Address(RVA = "0x2E62AD4", Offset = "0x2E62AD4", VA = "0x2E62AD4")]
	public static implicit operator BaseProfileInfo(FriendAccountInfo friendInfo)
	{
		return null;
	}

	[Token(Token = "0x6012EA7")]
	[Address(RVA = "0x2E62E38", Offset = "0x2E62E38", VA = "0x2E62E38")]
	public static implicit operator BaseProfileInfo(AccountInfoBasic basicInfo)
	{
		return null;
	}

	[Token(Token = "0x6012EA8")]
	[Address(RVA = "0x2E631F4", Offset = "0x2E631F4", VA = "0x2E631F4")]
	public static implicit operator BaseProfileInfo(GroupMemberInfo basicInfo)
	{
		return null;
	}

	[Token(Token = "0x6012EA9")]
	[Address(RVA = "0x2E6358C", Offset = "0x2E6358C", VA = "0x2E6358C")]
	public static implicit operator BaseProfileInfo(RoomPlayerInfo data)
	{
		return null;
	}

	[Token(Token = "0x6012EAA")]
	[Address(RVA = "0x2E637E4", Offset = "0x2E637E4", VA = "0x2E637E4")]
	public static implicit operator BaseProfileInfo(TextMsgReq chatMsg)
	{
		return null;
	}

	[Token(Token = "0x6012EAB")]
	[Address(RVA = "0x2E63AB8", Offset = "0x2E63AB8", VA = "0x2E63AB8")]
	public void ResetMyWeapons()
	{
	}

	[Token(Token = "0x6012EAC")]
	[Address(RVA = "0x2E63CDC", Offset = "0x2E63CDC", VA = "0x2E63CDC")]
	public void ResetMyVehicleSkins()
	{
	}

	[Token(Token = "0x6012EAD")]
	[Address(RVA = "0x2E63F00", Offset = "0x2E63F00", VA = "0x2E63F00")]
	public void RefreshMyShows(uint[] arr)
	{
	}

	[Token(Token = "0x6012EAE")]
	[Address(RVA = "0x2E640D8", Offset = "0x2E640D8", VA = "0x2E640D8")]
	public void RefreshGameBagId(uint id)
	{
	}

	[Token(Token = "0x6012EAF")]
	[Address(RVA = "0x2E64138", Offset = "0x2E64138", VA = "0x2E64138")]
	public uint GetGameBagShowId()
	{
		return default(uint);
	}

	[Token(Token = "0x6012EB0")]
	[Address(RVA = "0x2E64190", Offset = "0x2E64190", VA = "0x2E64190")]
	public uint GetShowWeapon()
	{
		return default(uint);
	}

	[Token(Token = "0x6012EB1")]
	[Address(RVA = "0x2E64270", Offset = "0x2E64270", VA = "0x2E64270")]
	public uint GetShowTransformer()
	{
		return default(uint);
	}

	[Token(Token = "0x6012EB2")]
	[Address(RVA = "0x2E64350", Offset = "0x2E64350", VA = "0x2E64350")]
	public uint GetGroupAnim()
	{
		return default(uint);
	}

	[Token(Token = "0x6012EB3")]
	[Address(RVA = "0x2E64430", Offset = "0x2E64430", VA = "0x2E64430")]
	public void RefreshEmoteSlots(ChoosedEmotes _choosedEmote)
	{
	}

	[Token(Token = "0x6012EB4")]
	[Address(RVA = "0x2E6466C", Offset = "0x2E6466C", VA = "0x2E6466C")]
	public void ChangeEmoteSlots(CSGetSelectedItemsRes res)
	{
	}

	[Token(Token = "0x6012EB5")]
	[Address(RVA = "0x2E6471C", Offset = "0x2E6471C", VA = "0x2E6471C")]
	public uint GetUnEquipEmoteSlotIndex(uint _id)
	{
		return default(uint);
	}

	[Token(Token = "0x6012EB6")]
	[Address(RVA = "0x2E647EC", Offset = "0x2E647EC", VA = "0x2E647EC")]
	public uint GetEmoteSlotIndex(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x6012EB7")]
	[Address(RVA = "0x2E648BC", Offset = "0x2E648BC", VA = "0x2E648BC")]
	public void ResetAllSlots()
	{
	}

	[Token(Token = "0x6012EB8")]
	[Address(RVA = "0x2E64940", Offset = "0x2E64940", VA = "0x2E64940")]
	public void RefreshSlots(uint[] slots)
	{
	}

	[Token(Token = "0x6012EB9")]
	[Address(RVA = "0x2E64D48", Offset = "0x2E64D48", VA = "0x2E64D48")]
	public uint EmoteEquippedCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6012EBA")]
	[Address(RVA = "0x2E64F38", Offset = "0x2E64F38", VA = "0x2E64F38")]
	public bool hasEquippedEmote(uint emoteID)
	{
		return default(bool);
	}

	[Token(Token = "0x6012EBB")]
	[Address(RVA = "0x2E65138", Offset = "0x2E65138", VA = "0x2E65138")]
	public List<uint> GetEquipedVehileIdList()
	{
		return null;
	}

	[Token(Token = "0x6012EBC")]
	[Address(RVA = "0x2E653B4", Offset = "0x2E653B4", VA = "0x2E653B4")]
	public List<uint> GetEquipedEmoteIdList()
	{
		return null;
	}

	[Token(Token = "0x6012EBD")]
	[Address(RVA = "0x2E65630", Offset = "0x2E65630", VA = "0x2E65630")]
	public List<uint> GetEquipedWeaponIdList()
	{
		return null;
	}
}
