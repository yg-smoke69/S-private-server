using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x20000EF")]
public class EmoteData : CSVBaseData
{
	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0x8")]
	public int[] HideClothEffectSlots;

	[Token(Token = "0x40005E6")]
	[FieldOffset(Offset = "0xC")]
	public uint iID;

	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x10")]
	public uint sortId;

	[Token(Token = "0x40005E8")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID SFXResourceID;

	[Token(Token = "0x40005E9")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID animationResIDMale;

	[Token(Token = "0x40005EA")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID animationResIDFemale;

	[Token(Token = "0x40005EB")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID propID;

	[Token(Token = "0x40005EC")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID propIDLeft;

	[Token(Token = "0x40005ED")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID propIDRight;

	[Token(Token = "0x40005EE")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID propIDHead;

	[Token(Token = "0x40005EF")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID inGameSceneIconResID;

	[Token(Token = "0x40005F0")]
	[FieldOffset(Offset = "0x34")]
	public List<ResourceID> VFXMaleIngame;

	[Token(Token = "0x40005F1")]
	[FieldOffset(Offset = "0x38")]
	public List<ResourceID> VFXMaleSystem;

	[Token(Token = "0x40005F2")]
	[FieldOffset(Offset = "0x3C")]
	public List<ResourceID> VFXFemaleIngame;

	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0x40")]
	public List<ResourceID> VFXFemaleSystem;

	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x44")]
	public ResourceID LeadDancerVFX;

	[Token(Token = "0x40005F5")]
	[FieldOffset(Offset = "0x48")]
	public bool IsLeadEmoteIngame;

	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x49")]
	public ESourceType sourceTypeKey;

	[Token(Token = "0x40005F7")]
	[FieldOffset(Offset = "0x4A")]
	public bool IsLeadEmote;

	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x4B")]
	public bool is_random;

	[Token(Token = "0x40005F9")]
	[FieldOffset(Offset = "0x4C")]
	public bool IsMoveEmote;

	[Token(Token = "0x40005FA")]
	[FieldOffset(Offset = "0x50")]
	public ResourceID FootStepsResID;

	[Token(Token = "0x40005FB")]
	[FieldOffset(Offset = "0x54")]
	public float[] MaleFootStepPlayTiming;

	[Token(Token = "0x40005FC")]
	[FieldOffset(Offset = "0x58")]
	public float[] FemaleFootStepPlayTiming;

	[Token(Token = "0x40005FD")]
	[FieldOffset(Offset = "0x5C")]
	public float MoveEmoteSpeed;

	[Token(Token = "0x40005FE")]
	[FieldOffset(Offset = "0x60")]
	public ResourceID AnimationMaleIdleID;

	[Token(Token = "0x40005FF")]
	[FieldOffset(Offset = "0x64")]
	public ResourceID AnimationFemaleIdleID;

	[Token(Token = "0x4000600")]
	[FieldOffset(Offset = "0x68")]
	public List<CollectionPrivilegeTagData> Privileges;

	[Token(Token = "0x4000601")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<CollectionPrivilegeTagData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600060F")]
	[Address(RVA = "0x2531550", Offset = "0x2531550", VA = "0x2531550")]
	public EmoteData()
	{
	}

	[Token(Token = "0x6000610")]
	[Address(RVA = "0x2531724", Offset = "0x2531724", VA = "0x2531724", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000611")]
	[Address(RVA = "0x2531788", Offset = "0x2531788", VA = "0x2531788", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000612")]
	[Address(RVA = "0x253305C", Offset = "0x253305C", VA = "0x253305C")]
	public EmotionRandomEffInfo GetRandomEffRes(bool islobby, bool isFemale)
	{
		return null;
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x25334D0", Offset = "0x25334D0", VA = "0x25334D0")]
	public ResourceID GetRandomEffResByIdx(bool isLobby, bool isFemale, uint idx)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x2533780", Offset = "0x2533780", VA = "0x2533780")]
	public int GetRandomEffCnt(bool islobby, bool isFemale)
	{
		return default(int);
	}

	[Token(Token = "0x6000615")]
	[Address(RVA = "0x25338A4", Offset = "0x25338A4", VA = "0x25338A4")]
	public List<AccountEmoteRandomID> ConstructLobbyGroupMemberRandomEff(List<GroupMemberInfo> member)
	{
		return null;
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x2533C50", Offset = "0x2533C50", VA = "0x2533C50")]
	public bool HasIdleEmotion(bool isFemale)
	{
		return default(bool);
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x2533D88", Offset = "0x2533D88", VA = "0x2533D88")]
	public float[] GetFootStepTimeing(bool isFemale)
	{
		return null;
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x2532F20", Offset = "0x2532F20", VA = "0x2532F20")]
	private void AddPrivilege(CollectionPrivilegeTagType type)
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x2533DF4", Offset = "0x2533DF4", VA = "0x2533DF4")]
	private static int _003CParseData_003Em__0(CollectionPrivilegeTagData a, CollectionPrivilegeTagData b)
	{
		return default(int);
	}
}
