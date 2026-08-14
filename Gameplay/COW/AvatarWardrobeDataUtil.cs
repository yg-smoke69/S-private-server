using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E73")]
public static class AvatarWardrobeDataUtil
{
	[Token(Token = "0x400BF87")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, string> m_SlotNameDic;

	[Token(Token = "0x600926B")]
	[Address(RVA = "0x236ACEC", Offset = "0x236ACEC", VA = "0x236ACEC")]
	public static AvatarWardrobeData GetWardrobeData(uint id)
	{
		return null;
	}

	[Token(Token = "0x600926C")]
	[Address(RVA = "0x236ADE0", Offset = "0x236ADE0", VA = "0x236ADE0")]
	public static string GetSlot(AvatarWardrobeData wData)
	{
		return null;
	}

	[Token(Token = "0x600926D")]
	[Address(RVA = "0x236B154", Offset = "0x236B154", VA = "0x236B154")]
	public static string GetSlot(UIModelAvatarBase.EWardrobeType t)
	{
		return null;
	}

	[Token(Token = "0x600926E")]
	[Address(RVA = "0x236B27C", Offset = "0x236B27C", VA = "0x236B27C")]
	public static string GetConflictSlot(string selectSlot, Dictionary<string, AvatarWardrobeData> slots, bool isFemale, uint avatarId)
	{
		return null;
	}

	[Token(Token = "0x600926F")]
	[Address(RVA = "0x236B720", Offset = "0x236B720", VA = "0x236B720")]
	public static void RemoveConflictSlot(AvatarWardrobeData wData, List<uint> cs, bool isFemale, uint avatarId, bool considerHidingTarget)
	{
	}

	[Token(Token = "0x6009270")]
	[Address(RVA = "0x236B454", Offset = "0x236B454", VA = "0x236B454")]
	private static string GetPotentialConflictSlot(string slot)
	{
		return null;
	}

	[Token(Token = "0x6009271")]
	[Address(RVA = "0x236B5AC", Offset = "0x236B5AC", VA = "0x236B5AC")]
	public static bool IsConflict(AvatarWardrobeData selectData, AvatarWardrobeData targetData, bool considerHidingTarget, bool isFemale, uint avatarId)
	{
		return default(bool);
	}

	[Token(Token = "0x6009272")]
	[Address(RVA = "0x236BA94", Offset = "0x236BA94", VA = "0x236BA94")]
	public static bool CheckCanEquipHair(AvatarWardrobeData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6009273")]
	[Address(RVA = "0x236BB14", Offset = "0x236BB14", VA = "0x236BB14")]
	public static bool CheckCanEquipFace(AvatarWardrobeData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6009274")]
	[Address(RVA = "0x236BB94", Offset = "0x236BB94", VA = "0x236BB94")]
	public static bool DoesLegendClothHaveTip(int legendType)
	{
		return default(bool);
	}

	[Token(Token = "0x6009275")]
	[Address(RVA = "0x236BCA0", Offset = "0x236BCA0", VA = "0x236BCA0")]
	public static void SetLegendClothTipCount(int legendType, bool haveNew)
	{
	}
}
