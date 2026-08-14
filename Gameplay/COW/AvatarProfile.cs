using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DA2")]
public class AvatarProfile : _Attribute
{
	[Token(Token = "0x401183F")]
	[FieldOffset(Offset = "0x8")]
	public uint AvatarID;

	[Token(Token = "0x4011840")]
	[FieldOffset(Offset = "0xC")]
	public int SortID;

	[Token(Token = "0x4011841")]
	[FieldOffset(Offset = "0x10")]
	public bool IsSelected;

	[Token(Token = "0x4011842")]
	[FieldOffset(Offset = "0x11")]
	public bool hasOwnAvatar;

	[Token(Token = "0x4011843")]
	[FieldOffset(Offset = "0x12")]
	public bool hasOwnAvatarItem;

	[Token(Token = "0x4011844")]
	[FieldOffset(Offset = "0x14")]
	public int CurProfileLevel;

	[Token(Token = "0x4011845")]
	[FieldOffset(Offset = "0x18")]
	public AvatarSkill CurSkill;

	[Token(Token = "0x4011846")]
	[FieldOffset(Offset = "0x1C")]
	private int unLockedSkillCount;

	[Token(Token = "0x4011847")]
	[FieldOffset(Offset = "0x20")]
	public bool IsAwakenSelect;

	[Token(Token = "0x4011848")]
	[FieldOffset(Offset = "0x24")]
	public uint ExpireTime;

	[Token(Token = "0x4011849")]
	[FieldOffset(Offset = "0x28")]
	public bool IsMarkedAvatar;

	[Token(Token = "0x401184A")]
	[FieldOffset(Offset = "0x2C")]
	private List<AvatarProfileDataOverrided> m_AvatarConfigDataList;

	[Token(Token = "0x401184B")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<int, uint> m_EquippedSkills;

	[Token(Token = "0x401184C")]
	[FieldOffset(Offset = "0x34")]
	private List<AvatarSuit> m_SuitList;

	[Token(Token = "0x401184D")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AvatarProfileDataOverrided> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700138F")]
	public uint CurDebrisCount
	{
		[Token(Token = "0x60131BF")]
		[Address(RVA = "0x234DA74", Offset = "0x234DA74", VA = "0x234DA74")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001390")]
	public bool HasOwnPermanentAvatar
	{
		[Token(Token = "0x60131C0")]
		[Address(RVA = "0x234DE54", Offset = "0x234DE54", VA = "0x234DE54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001391")]
	public int UnLockedSkillCount
	{
		[Token(Token = "0x60131C1")]
		[Address(RVA = "0x234DED0", Offset = "0x234DED0", VA = "0x234DED0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60131C2")]
		[Address(RVA = "0x234DF28", Offset = "0x234DF28", VA = "0x234DF28")]
		set
		{
		}
	}

	[Token(Token = "0x17001392")]
	public Dictionary<int, uint> EquippedSkills
	{
		[Token(Token = "0x60131C3")]
		[Address(RVA = "0x234DF88", Offset = "0x234DF88", VA = "0x234DF88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001393")]
	public CSSharedAvatarData BasicInfo
	{
		[Token(Token = "0x60131C4")]
		[Address(RVA = "0x234DFE0", Offset = "0x234DFE0", VA = "0x234DFE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001394")]
	public AvatarProfileDataOverrided CurProfileData
	{
		[Token(Token = "0x60131C5")]
		[Address(RVA = "0x234DD24", Offset = "0x234DD24", VA = "0x234DD24")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001395")]
	public AvatarProfileDataOverrided NextProfileData
	{
		[Token(Token = "0x60131C6")]
		[Address(RVA = "0x234DBEC", Offset = "0x234DBEC", VA = "0x234DBEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001396")]
	public List<AvatarProfileDataOverrided> AvatarConfigDataList
	{
		[Token(Token = "0x60131C7")]
		[Address(RVA = "0x234E0F4", Offset = "0x234E0F4", VA = "0x234E0F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001397")]
	public List<AvatarSuit> SuitList
	{
		[Token(Token = "0x60131CB")]
		[Address(RVA = "0x234E898", Offset = "0x234E898", VA = "0x234E898")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60131BE")]
	[Address(RVA = "0x234D9DC", Offset = "0x234D9DC", VA = "0x234D9DC")]
	public AvatarProfile()
	{
	}

	[Token(Token = "0x60131C8")]
	[Address(RVA = "0x234E3E4", Offset = "0x234E3E4", VA = "0x234E3E4")]
	public uint GetSkillBySlot(int slotID)
	{
		return default(uint);
	}

	[Token(Token = "0x60131C9")]
	[Address(RVA = "0x234E6D8", Offset = "0x234E6D8", VA = "0x234E6D8")]
	public void SetSkillBySlot(int slotID, uint skillID)
	{
	}

	[Token(Token = "0x60131CA")]
	[Address(RVA = "0x234E7D8", Offset = "0x234E7D8", VA = "0x234E7D8")]
	public void ClearEquippedSkills()
	{
	}

	[Token(Token = "0x60131CC")]
	[Address(RVA = "0x234EBA4", Offset = "0x234EBA4", VA = "0x234EBA4")]
	public void UpdateSuitOwnStatus(uint suitID, bool hasOwnComplete)
	{
	}

	[Token(Token = "0x60131CD")]
	[Address(RVA = "0x234ED48", Offset = "0x234ED48", VA = "0x234ED48")]
	public bool HasOwnRelatedPermanentAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x60131CE")]
	[Address(RVA = "0x234EFBC", Offset = "0x234EFBC", VA = "0x234EFBC", Slot = "4")]
	public int CompareTo(AvatarProfile other)
	{
		return default(int);
	}

	[Token(Token = "0x60131CF")]
	[Address(RVA = "0x234F0AC", Offset = "0x234F0AC", VA = "0x234F0AC")]
	private static int _003Cget_AvatarConfigDataList_003Em__0(AvatarProfileDataOverrided a, AvatarProfileDataOverrided b)
	{
		return default(int);
	}
}
