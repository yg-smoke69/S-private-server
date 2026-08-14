using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CC9")]
public class UMAData : MonoBehaviour
{
	[Token(Token = "0x2003CCA")]
	public enum EffectType
	{
		[Token(Token = "0x4019D4A")]
		EFFECTTYPE_NONE,
		[Token(Token = "0x4019D4B")]
		EFFECTTYPE_GOD,
		[Token(Token = "0x4019D4C")]
		EFFECTTYPE_FROZEN,
		[Token(Token = "0x4019D4D")]
		EFFECTTYPE_FREESTYLE,
		[Token(Token = "0x4019D4E")]
		EFFECTTYPE_SNOWBALLFROZEN
	}

	[Token(Token = "0x2003CCB")]
	public enum DynamicBoneType
	{
		[Token(Token = "0x4019D50")]
		None,
		[Token(Token = "0x4019D51")]
		DynamicBone,
		[Token(Token = "0x4019D52")]
		Flux
	}

	[Token(Token = "0x2003CCC")]
	public delegate void CharacterUpdatedDelgate(UMAData umaData);

	[Serializable]
	[Token(Token = "0x2003CCD")]
	public class GeneratedMaterials
	{
		[Token(Token = "0x4019D53")]
		[FieldOffset(Offset = "0x8")]
		public List<GeneratedMaterial> materials;

		[Token(Token = "0x601857B")]
		[Address(RVA = "0x2DF85CC", Offset = "0x2DF85CC", VA = "0x2DF85CC")]
		public GeneratedMaterials()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003CCE")]
	public class GeneratedMaterial
	{
		[Token(Token = "0x4019D54")]
		[FieldOffset(Offset = "0x8")]
		public UMAMaterial umaMaterial;

		[Token(Token = "0x4019D55")]
		[FieldOffset(Offset = "0xC")]
		public Material material;

		[Token(Token = "0x4019D56")]
		[FieldOffset(Offset = "0x10")]
		public List<MaterialFragment> materialFragments;

		[Token(Token = "0x4019D57")]
		[FieldOffset(Offset = "0x14")]
		public Texture[] resultingAtlasList;

		[Token(Token = "0x4019D58")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 cropResolution;

		[Token(Token = "0x4019D59")]
		[FieldOffset(Offset = "0x20")]
		public float resolutionScale;

		[Token(Token = "0x4019D5A")]
		[FieldOffset(Offset = "0x24")]
		public string[] textureNameList;

		[Token(Token = "0x601857C")]
		[Address(RVA = "0x2DFD448", Offset = "0x2DFD448", VA = "0x2DFD448")]
		public GeneratedMaterial()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003CCF")]
	public class MaterialFragment
	{
		[Token(Token = "0x4019D5B")]
		[FieldOffset(Offset = "0x8")]
		public int size;

		[Token(Token = "0x4019D5C")]
		[FieldOffset(Offset = "0xC")]
		public Color baseColor;

		[Token(Token = "0x4019D5D")]
		[FieldOffset(Offset = "0x1C")]
		public UMAMaterial umaMaterial;

		[Token(Token = "0x4019D5E")]
		[FieldOffset(Offset = "0x20")]
		public Rect[] rects;

		[Token(Token = "0x4019D5F")]
		[FieldOffset(Offset = "0x24")]
		public textureData[] overlays;

		[Token(Token = "0x4019D60")]
		[FieldOffset(Offset = "0x28")]
		public Color32[] overlayColors;

		[Token(Token = "0x4019D61")]
		[FieldOffset(Offset = "0x2C")]
		public Color[][] channelMask;

		[Token(Token = "0x4019D62")]
		[FieldOffset(Offset = "0x30")]
		public Color[][] channelAdditiveMask;

		[Token(Token = "0x4019D63")]
		[FieldOffset(Offset = "0x34")]
		public SlotData slotData;

		[Token(Token = "0x4019D64")]
		[FieldOffset(Offset = "0x38")]
		public OverlayData[] overlayData;

		[Token(Token = "0x4019D65")]
		[FieldOffset(Offset = "0x3C")]
		public Rect atlasRegion;

		[Token(Token = "0x4019D66")]
		[FieldOffset(Offset = "0x4C")]
		public bool isRectShared;

		[Token(Token = "0x4019D67")]
		[FieldOffset(Offset = "0x50")]
		public List<OverlayData> overlayList;

		[Token(Token = "0x4019D68")]
		[FieldOffset(Offset = "0x54")]
		public MaterialFragment rectFragment;

		[Token(Token = "0x4019D69")]
		[FieldOffset(Offset = "0x58")]
		public textureData baseOverlay;

		[Token(Token = "0x4019D6A")]
		[FieldOffset(Offset = "0x5C")]
		public int width;

		[Token(Token = "0x4019D6B")]
		[FieldOffset(Offset = "0x60")]
		public int height;

		[Token(Token = "0x601857D")]
		[Address(RVA = "0x2DFD4D4", Offset = "0x2DFD4D4", VA = "0x2DFD4D4")]
		public MaterialFragment()
		{
		}

		[Token(Token = "0x601857E")]
		[Address(RVA = "0x2DF1F44", Offset = "0x2DF1F44", VA = "0x2DF1F44")]
		public Color GetMultiplier(int overlay, int textureType)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Color);
		}

		[Token(Token = "0x601857F")]
		[Address(RVA = "0x2DF20DC", Offset = "0x2DF20DC", VA = "0x2DF20DC")]
		public Color32 GetAdditive(int overlay, int textureType)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Color32);
		}
	}

	[Serializable]
	[Token(Token = "0x2003CD0")]
	public class textureData
	{
		[Token(Token = "0x4019D6C")]
		[FieldOffset(Offset = "0x8")]
		public Texture[] textureList;

		[Token(Token = "0x4019D6D")]
		[FieldOffset(Offset = "0xC")]
		public Texture alphaTexture;

		[Token(Token = "0x4019D6E")]
		[FieldOffset(Offset = "0x10")]
		public OverlayDataAsset.OverlayType overlayType;

		[Token(Token = "0x6018580")]
		[Address(RVA = "0x2DFE0F4", Offset = "0x2DFE0F4", VA = "0x2DFE0F4")]
		public textureData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003CD1")]
	public class resultAtlasTexture
	{
		[Token(Token = "0x4019D6F")]
		[FieldOffset(Offset = "0x8")]
		public Texture[] textureList;

		[Token(Token = "0x6018581")]
		[Address(RVA = "0x2DFE0EC", Offset = "0x2DFE0EC", VA = "0x2DFE0EC")]
		public resultAtlasTexture()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003CD2")]
	public class UMARecipe
	{
		[Token(Token = "0x4019D70")]
		[FieldOffset(Offset = "0x8")]
		public RaceData raceData;

		[Token(Token = "0x4019D71")]
		[FieldOffset(Offset = "0xC")]
		protected Dictionary<string, int> mergedSharedColors;

		[Token(Token = "0x4019D72")]
		[FieldOffset(Offset = "0x10")]
		public SlotData[] slotDataList;

		[Token(Token = "0x4019D73")]
		[FieldOffset(Offset = "0x14")]
		public OverlayColorData[] sharedColors;

		[Token(Token = "0x6018582")]
		[Address(RVA = "0x2DF8F94", Offset = "0x2DF8F94", VA = "0x2DF8F94")]
		public UMARecipe()
		{
		}

		[Token(Token = "0x6018583")]
		[Address(RVA = "0x2DF92E0", Offset = "0x2DF92E0", VA = "0x2DF92E0")]
		public bool Validate()
		{
			return default(bool);
		}

		[Token(Token = "0x6018584")]
		[Address(RVA = "0x2DFD4DC", Offset = "0x2DFD4DC", VA = "0x2DFD4DC")]
		public void SetRace(RaceData raceData)
		{
		}

		[Token(Token = "0x6018585")]
		[Address(RVA = "0x2DFD4E4", Offset = "0x2DFD4E4", VA = "0x2DFD4E4")]
		public RaceData GetRace()
		{
			return null;
		}

		[Token(Token = "0x6018586")]
		[Address(RVA = "0x2DFBAC4", Offset = "0x2DFBAC4", VA = "0x2DFBAC4")]
		public void SetSlot(int index, SlotData slot)
		{
		}

		[Token(Token = "0x6018587")]
		[Address(RVA = "0x2DFBC0C", Offset = "0x2DFBC0C", VA = "0x2DFBC0C")]
		public void SetSlots(SlotData[] slots)
		{
		}

		[Token(Token = "0x6018588")]
		[Address(RVA = "0x2DFD4EC", Offset = "0x2DFD4EC", VA = "0x2DFD4EC")]
		public void MergeSlot(SlotData slot, bool dontSerialize)
		{
		}

		[Token(Token = "0x6018589")]
		[Address(RVA = "0x2DFBC44", Offset = "0x2DFBC44", VA = "0x2DFBC44")]
		public SlotData GetSlot(int index)
		{
			return null;
		}

		[Token(Token = "0x601858A")]
		[Address(RVA = "0x2DF79F0", Offset = "0x2DF79F0", VA = "0x2DF79F0")]
		public SlotData[] GetAllSlots()
		{
			return null;
		}

		[Token(Token = "0x601858B")]
		[Address(RVA = "0x2DFBCEC", Offset = "0x2DFBCEC", VA = "0x2DFBCEC")]
		public int GetSlotArraySize()
		{
			return default(int);
		}

		[Token(Token = "0x601858C")]
		[Address(RVA = "0x2DFDE54", Offset = "0x2DFDE54", VA = "0x2DFDE54")]
		public static bool OverlayListsMatch(List<OverlayData> list1, List<OverlayData> list2)
		{
			return default(bool);
		}

		[Token(Token = "0x601858D")]
		[Address(RVA = "0x2DFDC60", Offset = "0x2DFDC60", VA = "0x2DFDC60")]
		public void MergeMatchingOverlays()
		{
		}

		[Token(Token = "0x601858E")]
		[Address(RVA = "0x2DFE048", Offset = "0x2DFE048", VA = "0x2DFE048")]
		public UMARecipe Mirror()
		{
			return null;
		}

		[Token(Token = "0x601858F")]
		[Address(RVA = "0x2DFC398", Offset = "0x2DFC398", VA = "0x2DFC398")]
		public void Merge(UMARecipe recipe, bool dontSerialize)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003CD3")]
	public class BoneData
	{
		[Token(Token = "0x4019D74")]
		[FieldOffset(Offset = "0x8")]
		public Transform boneTransform;

		[Token(Token = "0x4019D75")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 originalBoneScale;

		[Token(Token = "0x4019D76")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 originalBonePosition;

		[Token(Token = "0x4019D77")]
		[FieldOffset(Offset = "0x24")]
		public Quaternion originalBoneRotation;

		[Token(Token = "0x6018590")]
		[Address(RVA = "0x2DFD3F4", Offset = "0x2DFD3F4", VA = "0x2DFD3F4")]
		public BoneData()
		{
		}
	}

	[Token(Token = "0x4019D14")]
	[FieldOffset(Offset = "0x0")]
	public static bool OptimizeMeshMemory;

	[Token(Token = "0x4019D15")]
	[FieldOffset(Offset = "0xC")]
	public SkinnedMeshRenderer myRenderer;

	[NonSerialized]
	[Token(Token = "0x4019D16")]
	[FieldOffset(Offset = "0x10")]
	public bool firstBake;

	[Token(Token = "0x4019D17")]
	[FieldOffset(Offset = "0x14")]
	public UMAGeneratorBase umaGenerator;

	[NonSerialized]
	[Token(Token = "0x4019D18")]
	[FieldOffset(Offset = "0x18")]
	public GeneratedMaterials generatedMaterials;

	[Token(Token = "0x4019D19")]
	[FieldOffset(Offset = "0x1C")]
	private LinkedListNode<UMAData> listNode;

	[Token(Token = "0x4019D1A")]
	[FieldOffset(Offset = "0x20")]
	public float atlasResolutionScale;

	[Token(Token = "0x4019D1B")]
	[FieldOffset(Offset = "0x24")]
	public bool atlasRelease;

	[Token(Token = "0x4019D1C")]
	[FieldOffset(Offset = "0x25")]
	public bool meshRelease;

	[Token(Token = "0x4019D1D")]
	[FieldOffset(Offset = "0x26")]
	public bool isMeshDirty;

	[Token(Token = "0x4019D1E")]
	[FieldOffset(Offset = "0x27")]
	public bool isShapeDirty;

	[Token(Token = "0x4019D1F")]
	[FieldOffset(Offset = "0x28")]
	public bool isTextureDirty;

	[Token(Token = "0x4019D20")]
	[FieldOffset(Offset = "0x29")]
	public bool isAtlasDirty;

	[Token(Token = "0x4019D21")]
	[FieldOffset(Offset = "0x2A")]
	public bool isLocalPlayer;

	[Token(Token = "0x4019D22")]
	[FieldOffset(Offset = "0x2B")]
	public bool isTeammate;

	[Token(Token = "0x4019D23")]
	[FieldOffset(Offset = "0x2C")]
	public bool noTextureMerge;

	[Token(Token = "0x4019D24")]
	[FieldOffset(Offset = "0x30")]
	public DynamicBoneType dynamicBoneType;

	[Token(Token = "0x4019D25")]
	[FieldOffset(Offset = "0x34")]
	public bool ignoreBlendShapes;

	[Token(Token = "0x4019D26")]
	[FieldOffset(Offset = "0x35")]
	public bool updateWhenOffsceen;

	[Token(Token = "0x4019D27")]
	[FieldOffset(Offset = "0x38")]
	public EffectType effectType;

	[Token(Token = "0x4019D28")]
	[FieldOffset(Offset = "0x3C")]
	public RuntimeAnimatorController animationController;

	[Token(Token = "0x4019D29")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, int> animatedBonesTable;

	[Token(Token = "0x4019D2A")]
	[FieldOffset(Offset = "0x44")]
	public Animator mAnimator;

	[Token(Token = "0x4019D2B")]
	[FieldOffset(Offset = "0x48")]
	public bool isThermalView;

	[Token(Token = "0x4019D2C")]
	[FieldOffset(Offset = "0x49")]
	public bool isPlanarShadow;

	[Token(Token = "0x4019D2D")]
	[FieldOffset(Offset = "0x4A")]
	private bool _003Ccancelled_003Ek__BackingField;

	[NonSerialized]
	[Token(Token = "0x4019D2E")]
	[FieldOffset(Offset = "0x4B")]
	public bool dirty;

	[Token(Token = "0x4019D2F")]
	[FieldOffset(Offset = "0x4C")]
	private bool isOfficiallyCreated;

	[Token(Token = "0x4019D30")]
	[FieldOffset(Offset = "0x50")]
	public CharacterUpdatedDelgate OnCharacterUpdatedFixed;

	[Token(Token = "0x4019D31")]
	[FieldOffset(Offset = "0x54")]
	public UMADataEvent CharacterCreated;

	[Token(Token = "0x4019D32")]
	[FieldOffset(Offset = "0x58")]
	public UMADataEvent CharacterDestroyed;

	[Token(Token = "0x4019D33")]
	[FieldOffset(Offset = "0x5C")]
	public UMADataEvent CharacterUpdated;

	[Token(Token = "0x4019D34")]
	[FieldOffset(Offset = "0x60")]
	public GameObject umaRoot;

	[Token(Token = "0x4019D35")]
	[FieldOffset(Offset = "0x64")]
	public UMARecipe umaRecipe;

	[Token(Token = "0x4019D36")]
	[FieldOffset(Offset = "0x68")]
	public Animator animator;

	[Token(Token = "0x4019D37")]
	[FieldOffset(Offset = "0x6C")]
	public UMASkeleton skeleton;

	[Token(Token = "0x4019D38")]
	[FieldOffset(Offset = "0x70")]
	public float characterHeight;

	[Token(Token = "0x4019D39")]
	[FieldOffset(Offset = "0x74")]
	public float characterRadius;

	[Token(Token = "0x4019D3A")]
	[FieldOffset(Offset = "0x78")]
	public float characterMass;

	[Token(Token = "0x4019D3B")]
	[FieldOffset(Offset = "0x7C")]
	private bool textureReady;

	[Token(Token = "0x4019D3C")]
	[FieldOffset(Offset = "0x7D")]
	private bool meshReady;

	[Token(Token = "0x4019D3D")]
	[FieldOffset(Offset = "0x7E")]
	public bool enableMipmap;

	[Token(Token = "0x4019D3E")]
	[FieldOffset(Offset = "0x7F")]
	public bool usingRendertargetPool;

	[Token(Token = "0x4019D3F")]
	[FieldOffset(Offset = "0x80")]
	public int textureScale;

	[Token(Token = "0x4019D40")]
	[FieldOffset(Offset = "0x84")]
	public float normalSpecTexScale;

	[Token(Token = "0x4019D41")]
	[FieldOffset(Offset = "0x88")]
	private bool mIsPausedDuringGenerating;

	[Token(Token = "0x4019D42")]
	[FieldOffset(Offset = "0x89")]
	public bool needGenerateMesh;

	[Token(Token = "0x4019D43")]
	[FieldOffset(Offset = "0x8A")]
	public bool usingRGB565;

	[Token(Token = "0x4019D44")]
	[FieldOffset(Offset = "0x4")]
	public static int PauseFrameCount;

	[Token(Token = "0x4019D45")]
	[FieldOffset(Offset = "0x8C")]
	private List<Texture> backUpTexture;

	[Token(Token = "0x4019D46")]
	[FieldOffset(Offset = "0x90")]
	private bool m_Hide;

	[Token(Token = "0x4019D47")]
	[FieldOffset(Offset = "0x91")]
	private bool m_releaseResource;

	[Token(Token = "0x4019D48")]
	[FieldOffset(Offset = "0x92")]
	private bool m_HasPendingDirtyData;

	[Token(Token = "0x170019B9")]
	public bool cancelled
	{
		[Token(Token = "0x6018542")]
		[Address(RVA = "0x2DF8A10", Offset = "0x2DF8A10", VA = "0x2DF8A10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6018543")]
		[Address(RVA = "0x2DF8A18", Offset = "0x2DF8A18", VA = "0x2DF8A18")]
		private set
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action<UMAData> OnCharacterCreated
	{
		[Token(Token = "0x6018544")]
		[Address(RVA = "0x2DF8A20", Offset = "0x2DF8A20", VA = "0x2DF8A20")]
		add
		{
		}
		[Token(Token = "0x6018545")]
		[Address(RVA = "0x2DF8B70", Offset = "0x2DF8B70", VA = "0x2DF8B70")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<UMAData> OnCharacterDestroyed
	{
		[Token(Token = "0x6018546")]
		[Address(RVA = "0x2DF8C34", Offset = "0x2DF8C34", VA = "0x2DF8C34")]
		add
		{
		}
		[Token(Token = "0x6018547")]
		[Address(RVA = "0x2DF8D20", Offset = "0x2DF8D20", VA = "0x2DF8D20")]
		remove
		{
		}
	}

	[Token(Token = "0x601853D")]
	[Address(RVA = "0x2DF84D8", Offset = "0x2DF84D8", VA = "0x2DF84D8")]
	public UMAData()
	{
	}

	[Token(Token = "0x601853E")]
	[Address(RVA = "0x2DF8658", Offset = "0x2DF8658", VA = "0x2DF8658")]
	public void MoveToList(LinkedList<UMAData> list)
	{
	}

	[Token(Token = "0x601853F")]
	[Address(RVA = "0x2DF876C", Offset = "0x2DF876C", VA = "0x2DF876C")]
	public void ResetAnimatedBones()
	{
	}

	[Token(Token = "0x6018540")]
	[Address(RVA = "0x2DF8810", Offset = "0x2DF8810", VA = "0x2DF8810")]
	public void RegisterAnimatedBone(int hash)
	{
	}

	[Token(Token = "0x6018541")]
	[Address(RVA = "0x2DF8910", Offset = "0x2DF8910", VA = "0x2DF8910")]
	public void RegisterAnimatedBoneHierarchy(int hash)
	{
	}

	[Token(Token = "0x6018548")]
	[Address(RVA = "0x2DF8DE4", Offset = "0x2DF8DE4", VA = "0x2DF8DE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6018549")]
	[Address(RVA = "0x2DF8E78", Offset = "0x2DF8E78", VA = "0x2DF8E78")]
	private void EnsureGenerator()
	{
	}

	[Token(Token = "0x601854A")]
	[Address(RVA = "0x2DF9020", Offset = "0x2DF9020", VA = "0x2DF9020")]
	public void SetupOnAwake()
	{
	}

	[Token(Token = "0x601854B")]
	[Address(RVA = "0x2DF90AC", Offset = "0x2DF90AC", VA = "0x2DF90AC")]
	public void Assign(UMAData other)
	{
	}

	[Token(Token = "0x601854C")]
	[Address(RVA = "0x2DF919C", Offset = "0x2DF919C", VA = "0x2DF919C")]
	public bool Validate()
	{
		return default(bool);
	}

	[Token(Token = "0x601854D")]
	[Address(RVA = "0x2DF9538", Offset = "0x2DF9538", VA = "0x2DF9538")]
	public bool UMAReady()
	{
		return default(bool);
	}

	[Token(Token = "0x601854E")]
	[Address(RVA = "0x2DF98E8", Offset = "0x2DF98E8", VA = "0x2DF98E8")]
	public void FireUpdatedEvent(bool cancelled)
	{
	}

	[Token(Token = "0x601854F")]
	[Address(RVA = "0x2DFA07C", Offset = "0x2DFA07C", VA = "0x2DFA07C", Slot = "4")]
	public virtual void Dirty()
	{
	}

	[Token(Token = "0x6018550")]
	[Address(RVA = "0x2DFA094", Offset = "0x2DFA094", VA = "0x2DFA094")]
	private void AddToDirtyUMA()
	{
	}

	[Token(Token = "0x6018551")]
	[Address(RVA = "0x2DFA178", Offset = "0x2DFA178", VA = "0x2DFA178")]
	public bool NeedGenerateCombinedMesh()
	{
		return default(bool);
	}

	[Token(Token = "0x6018552")]
	[Address(RVA = "0x2DFA244", Offset = "0x2DFA244", VA = "0x2DFA244")]
	public bool IsVisible()
	{
		return default(bool);
	}

	[Token(Token = "0x6018553")]
	[Address(RVA = "0x2DFA258", Offset = "0x2DFA258", VA = "0x2DFA258")]
	public void VisibilitySwitch(bool v, bool releaseResource = false)
	{
	}

	[Token(Token = "0x6018554")]
	[Address(RVA = "0x2DFA61C", Offset = "0x2DFA61C", VA = "0x2DFA61C")]
	public void SetUMARendererActive(bool active)
	{
	}

	[Token(Token = "0x6018555")]
	[Address(RVA = "0x2DFA6F8", Offset = "0x2DFA6F8", VA = "0x2DFA6F8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6018556")]
	[Address(RVA = "0x2DFADA8", Offset = "0x2DFADA8", VA = "0x2DFADA8")]
	public void CleanAvatar()
	{
	}

	[Token(Token = "0x6018557")]
	[Address(RVA = "0x2DFB1CC", Offset = "0x2DFB1CC", VA = "0x2DFB1CC")]
	public void CleanTextureSingle(Texture tempTexture)
	{
	}

	[Token(Token = "0x6018558")]
	[Address(RVA = "0x2DFAA34", Offset = "0x2DFAA34", VA = "0x2DFAA34")]
	public void CleanTextures()
	{
	}

	[Token(Token = "0x6018559")]
	[Address(RVA = "0x2DF7E38", Offset = "0x2DF7E38", VA = "0x2DF7E38")]
	public void CleanMesh(bool destroyRenderer)
	{
	}

	[Token(Token = "0x601855A")]
	[Address(RVA = "0x2DFA3F0", Offset = "0x2DFA3F0", VA = "0x2DFA3F0")]
	public void ReleaseMesh()
	{
	}

	[Token(Token = "0x601855B")]
	[Address(RVA = "0x2DFB344", Offset = "0x2DFB344", VA = "0x2DFB344")]
	public void backUpTextures()
	{
	}

	[Token(Token = "0x601855C")]
	[Address(RVA = "0x2DFA8D0", Offset = "0x2DFA8D0", VA = "0x2DFA8D0")]
	public void CleanBackUpTextures()
	{
	}

	[Token(Token = "0x601855D")]
	[Address(RVA = "0x2DFB5E0", Offset = "0x2DFB5E0", VA = "0x2DFB5E0")]
	public RenderTexture GetFirstRenderTexture()
	{
		return null;
	}

	[Token(Token = "0x601855E")]
	[Address(RVA = "0x2DFBA04", Offset = "0x2DFBA04", VA = "0x2DFBA04")]
	public GameObject GetBoneGameObject(string boneName)
	{
		return null;
	}

	[Token(Token = "0x601855F")]
	[Address(RVA = "0x2DFBA50", Offset = "0x2DFBA50", VA = "0x2DFBA50")]
	public GameObject GetBoneGameObject(int boneHash)
	{
		return null;
	}

	[Token(Token = "0x6018560")]
	[Address(RVA = "0x2DF6A78", Offset = "0x2DF6A78", VA = "0x2DF6A78")]
	public void Dirty(bool dnaDirty, bool textureDirty, bool meshDirty)
	{
	}

	[Token(Token = "0x6018561")]
	[Address(RVA = "0x2DFBA8C", Offset = "0x2DFBA8C", VA = "0x2DFBA8C")]
	public void SetSlot(int index, SlotData slot)
	{
	}

	[Token(Token = "0x6018562")]
	[Address(RVA = "0x2DFBBE4", Offset = "0x2DFBBE4", VA = "0x2DFBBE4")]
	public void SetSlots(SlotData[] slots)
	{
	}

	[Token(Token = "0x6018563")]
	[Address(RVA = "0x2DFBC14", Offset = "0x2DFBC14", VA = "0x2DFBC14")]
	public SlotData GetSlot(int index)
	{
		return null;
	}

	[Token(Token = "0x6018564")]
	[Address(RVA = "0x2DFBCB4", Offset = "0x2DFBCB4", VA = "0x2DFBCB4")]
	public int GetSlotArraySize()
	{
		return default(int);
	}

	[Token(Token = "0x6018565")]
	[Address(RVA = "0x2DFBD10", Offset = "0x2DFBD10", VA = "0x2DFBD10")]
	public UMASkeleton GetSkeleton()
	{
		return null;
	}

	[Token(Token = "0x6018566")]
	[Address(RVA = "0x2DFBD18", Offset = "0x2DFBD18", VA = "0x2DFBD18")]
	public void GotoTPose()
	{
	}

	[Token(Token = "0x6018567")]
	[Address(RVA = "0x2DFC0A4", Offset = "0x2DFC0A4", VA = "0x2DFC0A4")]
	public int[] GetAnimatedBones()
	{
		return null;
	}

	[Token(Token = "0x6018568")]
	[Address(RVA = "0x2DFC2E0", Offset = "0x2DFC2E0", VA = "0x2DFC2E0")]
	public void FireCharacterBegunEvents()
	{
	}

	[Token(Token = "0x6018569")]
	[Address(RVA = "0x2DFC2E4", Offset = "0x2DFC2E4", VA = "0x2DFC2E4")]
	public void FireDNAAppliedEvents()
	{
	}

	[Token(Token = "0x601856A")]
	[Address(RVA = "0x2DF9AD4", Offset = "0x2DF9AD4", VA = "0x2DF9AD4")]
	public void FireCharacterCompletedEvents()
	{
	}

	[Token(Token = "0x601856B")]
	[Address(RVA = "0x2DFC2E8", Offset = "0x2DFC2E8", VA = "0x2DFC2E8")]
	public void AddAdditionalRecipes(UMARecipeBase[] umaAdditionalRecipes, UMAContext context)
	{
	}

	[Token(Token = "0x601856C")]
	[Address(RVA = "0x2DFCB28", Offset = "0x2DFCB28", VA = "0x2DFCB28")]
	public void SetMeshReady()
	{
	}

	[Token(Token = "0x601856D")]
	[Address(RVA = "0x2DFCB40", Offset = "0x2DFCB40", VA = "0x2DFCB40")]
	public void SetTextureReady()
	{
	}

	[Token(Token = "0x601856E")]
	[Address(RVA = "0x2DFCB54", Offset = "0x2DFCB54", VA = "0x2DFCB54")]
	private void OnApplicationPause(bool paused)
	{
	}

	[Token(Token = "0x601856F")]
	[Address(RVA = "0x2DFCCB8", Offset = "0x2DFCCB8", VA = "0x2DFCCB8")]
	public void SetAnimator(Animator amtr)
	{
	}

	[Token(Token = "0x6018570")]
	[Address(RVA = "0x2DF9AD8", Offset = "0x2DF9AD8", VA = "0x2DF9AD8")]
	public void UpdateRenderVisible(bool visible)
	{
	}

	[Token(Token = "0x6018571")]
	[Address(RVA = "0x2DF7140", Offset = "0x2DF7140", VA = "0x2DF7140")]
	public void SetUpdateWhenOffSceen(bool flag)
	{
	}

	[Token(Token = "0x6018572")]
	[Address(RVA = "0x2DFCCC0", Offset = "0x2DFCCC0", VA = "0x2DFCCC0")]
	public void SwitchEffect(EffectType effect)
	{
	}

	[Token(Token = "0x6018573")]
	[Address(RVA = "0x2DFCD50", Offset = "0x2DFCD50", VA = "0x2DFCD50")]
	public static void ChangeRenderEffect(SkinnedMeshRenderer renderer, EffectType effect)
	{
	}

	[Token(Token = "0x6018574")]
	[Address(RVA = "0x2DFD110", Offset = "0x2DFD110", VA = "0x2DFD110")]
	public void SetAvatartColor(Color color)
	{
	}

	[Token(Token = "0x6018575")]
	[Address(RVA = "0x2DFD2A8", Offset = "0x2DFD2A8", VA = "0x2DFD2A8")]
	public bool GetMeshBounds(ref Bounds bound)
	{
		return default(bool);
	}
}
