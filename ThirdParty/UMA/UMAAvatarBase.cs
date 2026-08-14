using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA.Simple;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CC3")]
public abstract class UMAAvatarBase : MonoBehaviour, _Attribute
{
	[Token(Token = "0x4019CEF")]
	[FieldOffset(Offset = "0xC")]
	public UMAContext context;

	[Token(Token = "0x4019CF0")]
	[FieldOffset(Offset = "0x10")]
	public UMAData umaData;

	[Token(Token = "0x4019CF1")]
	[FieldOffset(Offset = "0x14")]
	public UMARecipeBase umaRecipe;

	[Token(Token = "0x4019CF2")]
	[FieldOffset(Offset = "0x18")]
	public UMARecipeBase[] mUmaAdditionalRecipes;

	[Token(Token = "0x4019CF3")]
	[FieldOffset(Offset = "0x1C")]
	public UMAGeneratorBase umaGenerator;

	[Token(Token = "0x4019CF4")]
	[FieldOffset(Offset = "0x20")]
	public RuntimeAnimatorController animationController;

	[Token(Token = "0x4019CF5")]
	[FieldOffset(Offset = "0x24")]
	protected RaceData umaRace;

	[Token(Token = "0x4019CF6")]
	[FieldOffset(Offset = "0x28")]
	public UMADataEvent CharacterCreated;

	[Token(Token = "0x4019CF7")]
	[FieldOffset(Offset = "0x2C")]
	public UMADataEvent CharacterDestroyed;

	[Token(Token = "0x4019CF8")]
	[FieldOffset(Offset = "0x30")]
	public UMADataEvent CharacterUpdated;

	[Token(Token = "0x4019CF9")]
	[FieldOffset(Offset = "0x34")]
	public bool rebuildSkeleton;

	[Token(Token = "0x4019CFA")]
	[FieldOffset(Offset = "0x0")]
	public static bool ReleaseDataOnRaceChange;

	[Token(Token = "0x4019CFB")]
	[FieldOffset(Offset = "0x38")]
	public string override1PSlotName;

	[Token(Token = "0x4019CFC")]
	[FieldOffset(Offset = "0x3C")]
	public UMAMaterial source1PMaterial;

	[Token(Token = "0x4019CFD")]
	[FieldOffset(Offset = "0x40")]
	public UMAMaterial override1PMaterial;

	[Token(Token = "0x4019CFE")]
	[FieldOffset(Offset = "0x44")]
	public bool m_IsForceChangeRace;

	[Token(Token = "0x170019B6")]
	public UMAData UmaData
	{
		[Token(Token = "0x6018504")]
		[Address(RVA = "0x2DF69F4", Offset = "0x2DF69F4", VA = "0x2DF69F4", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019B7")]
	public RaceData[] AvailableRaces
	{
		[Token(Token = "0x6018509")]
		[Address(RVA = "0x2DF6D3C", Offset = "0x2DF6D3C", VA = "0x2DF6D3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019B8")]
	public OverlayColorData[] CurrentSharedColors
	{
		[Token(Token = "0x601850A")]
		[Address(RVA = "0x2DF6D84", Offset = "0x2DF6D84", VA = "0x2DF6D84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60184FE")]
	[Address(RVA = "0x2DF644C", Offset = "0x2DF644C", VA = "0x2DF644C")]
	protected UMAAvatarBase()
	{
	}

	[Token(Token = "0x60184FF")]
	[Address(RVA = "0x2DF6454", Offset = "0x2DF6454", VA = "0x2DF6454", Slot = "18")]
	public void SetForceChangeRace()
	{
	}

	[Token(Token = "0x6018500")]
	[Address(RVA = "0x2DF6460", Offset = "0x2DF6460", VA = "0x2DF6460", Slot = "19")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x6018501")]
	[Address(RVA = "0x2DF6470", Offset = "0x2DF6470", VA = "0x2DF6470", Slot = "20")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x6018502")]
	[Address(RVA = "0x2DF67F4", Offset = "0x2DF67F4", VA = "0x2DF67F4", Slot = "21")]
	public virtual UMAContextIndividual UseIndividualContextCache(SlotOverlayAssetCache cache)
	{
		return null;
	}

	[Token(Token = "0x6018503")]
	[Address(RVA = "0x2DF69EC", Offset = "0x2DF69EC", VA = "0x2DF69EC", Slot = "4")]
	public GameObject GetGameObject()
	{
		return null;
	}

	[Token(Token = "0x6018505")]
	[Address(RVA = "0x2DF69FC", Offset = "0x2DF69FC", VA = "0x2DF69FC", Slot = "22")]
	public void ForceUpdate(bool DnaDirty, bool TextureDirty = false, bool MeshDirty = false)
	{
	}

	[Token(Token = "0x6018506")]
	[Address(RVA = "0x2DF6AD0", Offset = "0x2DF6AD0", VA = "0x2DF6AD0")]
	public void UpdateSameRace()
	{
	}

	[Token(Token = "0x6018507")]
	[Address(RVA = "0x2DF6B14", Offset = "0x2DF6B14", VA = "0x2DF6B14")]
	public void UpdateNewRace()
	{
	}

	[Token(Token = "0x6018508")]
	[Address(RVA = "0x2DF6C90", Offset = "0x2DF6C90", VA = "0x2DF6C90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x601850B")]
	[Address(RVA = "0x2DF6DBC", Offset = "0x2DF6DBC", VA = "0x2DF6DBC", Slot = "6")]
	public void SetEnableMipMap(bool enableMipMap)
	{
	}

	[Token(Token = "0x601850C")]
	[Address(RVA = "0x2DF6E6C", Offset = "0x2DF6E6C", VA = "0x2DF6E6C", Slot = "7")]
	public void SetEnableRenderTexturePool(bool flag)
	{
	}

	[Token(Token = "0x601850D")]
	[Address(RVA = "0x2DF6F1C", Offset = "0x2DF6F1C", VA = "0x2DF6F1C", Slot = "8")]
	public void SetTextureScaleFactor(int scale)
	{
	}

	[Token(Token = "0x601850E")]
	[Address(RVA = "0x2DF6FCC", Offset = "0x2DF6FCC", VA = "0x2DF6FCC", Slot = "9")]
	public void SetNormalSpecTexScale(float scale)
	{
	}

	[Token(Token = "0x601850F")]
	[Address(RVA = "0x2DF7088", Offset = "0x2DF7088", VA = "0x2DF7088", Slot = "10")]
	public void SetUpdateWhenOffSceen(bool flag)
	{
	}

	[Token(Token = "0x6018510")]
	[Address(RVA = "0x2DF7200", Offset = "0x2DF7200", VA = "0x2DF7200", Slot = "11")]
	public void SetNeedGenerateMesh(bool needMesh)
	{
	}

	[Token(Token = "0x6018511")]
	[Address(RVA = "0x2DF72B0", Offset = "0x2DF72B0", VA = "0x2DF72B0", Slot = "12")]
	public void SetUsingRGB565(bool needMesh)
	{
	}

	[Token(Token = "0x6018512")]
	[Address(RVA = "0x2DF7360", Offset = "0x2DF7360", VA = "0x2DF7360", Slot = "13")]
	public void SetAtlasResolutionScale(float scale)
	{
	}

	[Token(Token = "0x6018513")]
	[Address(RVA = "0x2DF741C", Offset = "0x2DF741C", VA = "0x2DF741C", Slot = "14")]
	public void SetNoMergeTexture(bool noMerge)
	{
	}

	[Token(Token = "0x6018514")]
	[Address(RVA = "0x2DF74CC", Offset = "0x2DF74CC", VA = "0x2DF74CC")]
	protected void SetBaseOverlayLimitSize(RaceData racedata)
	{
	}

	[Token(Token = "0x6018515")]
	[Address(RVA = "0x2DF7520", Offset = "0x2DF7520", VA = "0x2DF7520")]
	protected void SetOverlayLimitSize(int limitSize, UMAData.UMARecipe cachedRecipe, bool ignoreSkin = false)
	{
	}

	[Token(Token = "0x6018516")]
	[Address(RVA = "0x2DF75A8", Offset = "0x2DF75A8", VA = "0x2DF75A8")]
	public static void SetOverlayLimitSize(int limitSize, SlotData s, bool ignoreSkin = false)
	{
	}

	[Token(Token = "0x6018517")]
	[Address(RVA = "0x2DF7720", Offset = "0x2DF7720", VA = "0x2DF7720", Slot = "23")]
	public virtual void EnableDebugLog(bool enable)
	{
	}

	[Token(Token = "0x6018518")]
	[Address(RVA = "0x2DF7724", Offset = "0x2DF7724", VA = "0x2DF7724", Slot = "24")]
	public virtual void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x6018519")]
	[Address(RVA = "0x2DF7728", Offset = "0x2DF7728", VA = "0x2DF7728")]
	protected void Override1PSlotMaterials()
	{
	}

	[Token(Token = "0x601851A")]
	[Address(RVA = "0x2DF79F8", Offset = "0x2DF79F8", VA = "0x2DF79F8")]
	protected void CleanMeshForRebuildSkeleton()
	{
	}
}
