using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000B8")]
public class AvatarWardrobeData : CsvDataIndexedReading, _Attribute, IConvertible
{
	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x8")]
	public string recipeStrInLobby;

	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0xC")]
	public string recipeStrInGame;

	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x10")]
	public string recipeStrInLobby_F;

	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x14")]
	public string recipeStrInGame_F;

	[Token(Token = "0x400046A")]
	[FieldOffset(Offset = "0x18")]
	public uint iID;

	[Token(Token = "0x400046B")]
	[FieldOffset(Offset = "0x1C")]
	public uint avatarID;

	[Token(Token = "0x400046C")]
	[FieldOffset(Offset = "0x20")]
	public uint setID;

	[Token(Token = "0x400046D")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID idleAnimResID;

	[Token(Token = "0x400046E")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID showPoseAnimResID;

	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID showPoseEffectResID;

	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID DecorPropIDRoot;

	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x34")]
	public ResourceID DecorPropIDLeft;

	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x38")]
	public ResourceID DecorPropIDRight;

	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x3C")]
	public ResourceID EffectID_F;

	[Token(Token = "0x4000474")]
	[FieldOffset(Offset = "0x40")]
	public ResourceID EffectID_M;

	[Token(Token = "0x4000475")]
	[FieldOffset(Offset = "0x44")]
	public ResourceID EffectID_3P_F;

	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x48")]
	public ResourceID EffectID_3P_M;

	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0x4C")]
	public byte wardrobeType;

	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0x4D")]
	public bool isDefault;

	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0x4E")]
	public bool BackpackSwitch;

	[Token(Token = "0x400047A")]
	[FieldOffset(Offset = "0x4F")]
	public bool HasSpecialData;

	[Token(Token = "0x400047B")]
	public const byte HeadAdditiveSlotId = 14;

	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0x50")]
	public ResourceID FootHaloResId;

	[Token(Token = "0x400047D")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<uint, List<ClothesSpecialData>> avatarSpetialRecipes;

	[Token(Token = "0x400047E")]
	[FieldOffset(Offset = "0x54")]
	public bool EffectForceShow;

	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0x58")]
	public uint TeamID;

	[Token(Token = "0x170000FD")]
	public bool IsHeadAdditiveSlot
	{
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x2365580", Offset = "0x2365580", VA = "0x2365580")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000FE")]
	public bool HideBackpack
	{
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x2365F64", Offset = "0x2365F64", VA = "0x2365F64")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x2366070", Offset = "0x2366070", VA = "0x2366070")]
		set
		{
		}
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x2362D78", Offset = "0x2362D78", VA = "0x2362D78")]
	public AvatarWardrobeData()
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x2362E6C", Offset = "0x2362E6C", VA = "0x2362E6C", Slot = "10")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x2362EC4", Offset = "0x2362EC4", VA = "0x2362EC4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x2362F28", Offset = "0x2362F28", VA = "0x2362F28", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0x2363A78", Offset = "0x2363A78", VA = "0x2363A78", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x23650D0", Offset = "0x23650D0", VA = "0x23650D0")]
	public static void ClearAvatarSpecialData()
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x23651A4", Offset = "0x23651A4", VA = "0x23651A4")]
	public void AddAvatarSpecialData(ClothesSpecialData c)
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x236535C", Offset = "0x236535C", VA = "0x236535C")]
	private ClothesSpecialData GetAvatarData(uint avatarID)
	{
		return null;
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x23655EC", Offset = "0x23655EC", VA = "0x23655EC")]
	public bool HasLobbyRecipeForAvatar(uint avatarID, bool female)
	{
		return default(bool);
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x236577C", Offset = "0x236577C", VA = "0x236577C")]
	public string GetLobbyRecipeForAvatar(uint avatarID, bool female)
	{
		return null;
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x236594C", Offset = "0x236594C", VA = "0x236594C")]
	public string GetGameRecipeForAvatar(uint avatarID, bool female)
	{
		return null;
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x2365808", Offset = "0x2365808", VA = "0x2365808")]
	private string GetRecipeForAvatar(bool lobby, uint avatarID, bool female)
	{
		return null;
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x23659D8", Offset = "0x23659D8", VA = "0x23659D8")]
	private string GetRecipeForAvatarRaw(bool lobby, uint avatarID, bool female)
	{
		return null;
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x2365A74", Offset = "0x2365A74", VA = "0x2365A74")]
	public string GetArbitraryLobbyRecipe()
	{
		return null;
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x2365D6C", Offset = "0x2365D6C", VA = "0x2365D6C", Slot = "9")]
	public int CompareTo(AvatarWardrobeData other)
	{
		return default(int);
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x23661F0", Offset = "0x23661F0", VA = "0x23661F0")]
	public ResourceID GetEffectResID(bool is1P, bool isFemale)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x2366288", Offset = "0x2366288", VA = "0x2366288")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x2366290", Offset = "0x2366290", VA = "0x2366290")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
