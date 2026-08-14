using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Token(Token = "0x2003CDD")]
public abstract class UMAGeneratorBuiltin : UMAGeneratorBase
{
	[NonSerialized]
	[Token(Token = "0x4019DA1")]
	[FieldOffset(Offset = "0x1C")]
	protected UMAData umaData;

	[NonSerialized]
	[Token(Token = "0x4019DA2")]
	[FieldOffset(Offset = "0x20")]
	protected List<UMAData> umaDirtyList;

	[Token(Token = "0x4019DA3")]
	[FieldOffset(Offset = "0x24")]
	private LinkedList<UMAData> cleanUmas;

	[Token(Token = "0x4019DA4")]
	[FieldOffset(Offset = "0x28")]
	private LinkedList<UMAData> dirtyUmas;

	[Token(Token = "0x4019DA5")]
	[FieldOffset(Offset = "0x2C")]
	private UMAGeneratorCoroutine activeGeneratorCoroutine;

	[Token(Token = "0x4019DA6")]
	[FieldOffset(Offset = "0x30")]
	public Transform textureMergePrefab;

	[Token(Token = "0x4019DA7")]
	[FieldOffset(Offset = "0x34")]
	public UMAMeshCombiner meshCombiner;

	[Token(Token = "0x4019DA8")]
	[FieldOffset(Offset = "0x0")]
	public static bool EnableFixWorkSyncRemoveData;

	[Token(Token = "0x4019DA9")]
	[FieldOffset(Offset = "0x38")]
	public int InitialScaleFactor;

	[Token(Token = "0x4019DAA")]
	[FieldOffset(Offset = "0x3C")]
	public bool fastGeneration;

	[Token(Token = "0x4019DAB")]
	[FieldOffset(Offset = "0x1")]
	public static bool EnableGC;

	[Token(Token = "0x4019DAC")]
	[FieldOffset(Offset = "0x40")]
	private int forceGarbageCollect;

	[Token(Token = "0x4019DAD")]
	[FieldOffset(Offset = "0x44")]
	public int garbageCollectionRate;

	[Token(Token = "0x4019DAE")]
	[FieldOffset(Offset = "0x48")]
	private Stopwatch stopWatch;

	[Token(Token = "0x4019DAF")]
	[FieldOffset(Offset = "0x4")]
	public static int lastExceptionFrame;

	[Token(Token = "0x4019DB0")]
	[FieldOffset(Offset = "0x8")]
	public static int logExceptionInterval;

	[NonSerialized]
	[Token(Token = "0x4019DB1")]
	[FieldOffset(Offset = "0x50")]
	public long ElapsedTicks;

	[NonSerialized]
	[Token(Token = "0x4019DB2")]
	[FieldOffset(Offset = "0x58")]
	public long DnaChanged;

	[NonSerialized]
	[Token(Token = "0x4019DB3")]
	[FieldOffset(Offset = "0x60")]
	public long TextureChanged;

	[NonSerialized]
	[Token(Token = "0x4019DB4")]
	[FieldOffset(Offset = "0x68")]
	public long SlotsChanged;

	[NonSerialized]
	[Token(Token = "0x4019DB5")]
	[FieldOffset(Offset = "0x70")]
	public bool ReuseDynamicBone;

	[NonSerialized]
	[Token(Token = "0x4019DB6")]
	[FieldOffset(Offset = "0x71")]
	private bool ReuseMaterial;

	[Token(Token = "0x4019DB7")]
	[FieldOffset(Offset = "0x74")]
	private Dictionary<int, List<Material>> recycledMaterials;

	[Token(Token = "0x4019DB8")]
	[FieldOffset(Offset = "0x78")]
	private List<UMAMaterial> recyclingUmaMaterials;

	[Token(Token = "0x4019DB9")]
	[FieldOffset(Offset = "0x7C")]
	private List<Material> recyclingMaterials;

	[Token(Token = "0x4019DBA")]
	private const int RecycleMaterialMaxCntEach = 5;

	[Token(Token = "0x4019DBB")]
	[FieldOffset(Offset = "0x80")]
	private List<DynamicBone> dbBones;

	[Token(Token = "0x4019DBC")]
	[FieldOffset(Offset = "0x84")]
	private List<HangCollider> hangColliders;

	[Token(Token = "0x60185BD")]
	[Address(RVA = "0x2E036BC", Offset = "0x2E036BC", VA = "0x2E036BC")]
	protected UMAGeneratorBuiltin()
	{
	}

	[Token(Token = "0x60185BE")]
	[Address(RVA = "0x2DFB0EC", Offset = "0x2DFB0EC", VA = "0x2DFB0EC")]
	public void RemoveFromCleanList(UMAData data)
	{
	}

	[Token(Token = "0x60185BF")]
	[Address(RVA = "0x2E03834", Offset = "0x2E03834", VA = "0x2E03834")]
	public int GetInitialScaleFactor(UMAData data)
	{
		return default(int);
	}

	[Token(Token = "0x60185C0")]
	[Address(RVA = "0x2E03860", Offset = "0x2E03860", VA = "0x2E03860", Slot = "12")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x60185C1")]
	[Address(RVA = "0x2E0386C", Offset = "0x2E0386C", VA = "0x2E0386C", Slot = "13")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x60185C2")]
	[Address(RVA = "0x2E03B24", Offset = "0x2E03B24", VA = "0x2E03B24", Slot = "10")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x60185C3")]
	[Address(RVA = "0x2E03F10", Offset = "0x2E03F10", VA = "0x2E03F10")]
	private void Update()
	{
	}

	[Token(Token = "0x60185C4")]
	[Address(RVA = "0x2E03FEC", Offset = "0x2E03FEC", VA = "0x2E03FEC")]
	public void EnableReuseMaterial()
	{
	}

	[Token(Token = "0x60185C5")]
	[Address(RVA = "0x2E040DC", Offset = "0x2E040DC", VA = "0x2E040DC")]
	private bool CheckRenderTextures()
	{
		return default(bool);
	}

	[Token(Token = "0x60185C6")]
	[Address(RVA = "0x2E041B4", Offset = "0x2E041B4", VA = "0x2E041B4")]
	private RenderTexture FindRenderTexture()
	{
		return null;
	}

	[Token(Token = "0x60185C7")]
	[Address(RVA = "0x2E043BC", Offset = "0x2E043BC", VA = "0x2E043BC", Slot = "8")]
	public override void WorkSync(UMAData umaData)
	{
	}

	[Token(Token = "0x60185C8")]
	[Address(RVA = "0x2E046E8", Offset = "0x2E046E8", VA = "0x2E046E8", Slot = "9")]
	public override void RemoveData(UMAData data)
	{
	}

	[Token(Token = "0x60185C9")]
	[Address(RVA = "0x2E04878", Offset = "0x2E04878", VA = "0x2E04878", Slot = "7")]
	public override void Work()
	{
	}

	[Token(Token = "0x60185CA")]
	[Address(RVA = "0x2E042E0", Offset = "0x2E042E0", VA = "0x2E042E0")]
	private void RebuildAllRenderTextures()
	{
	}

	[Token(Token = "0x60185CB")]
	[Address(RVA = "0x2E04950", Offset = "0x2E04950", VA = "0x2E04950")]
	private void RebuildRenderTexture(UMAData data)
	{
	}

	[Token(Token = "0x60185CC")]
	[Address(RVA = "0x2E04B30", Offset = "0x2E04B30", VA = "0x2E04B30")]
	private TextureProcessBaseCoroutine CreateAndPrepareTextureProcess(UMAData data)
	{
		return null;
	}

	[Token(Token = "0x60185CD")]
	[Address(RVA = "0x2E04BD0", Offset = "0x2E04BD0", VA = "0x2E04BD0", Slot = "14")]
	public virtual bool HandleDirtyUpdate(UMAData data, bool fastGen)
	{
		return default(bool);
	}

	[Token(Token = "0x60185CE")]
	[Address(RVA = "0x2E051DC", Offset = "0x2E051DC", VA = "0x2E051DC")]
	private void PrepareGeneratedMaterialsToRecycle(UMAData.GeneratedMaterials generatedMaterials)
	{
	}

	[Token(Token = "0x60185CF")]
	[Address(RVA = "0x2E055F4", Offset = "0x2E055F4", VA = "0x2E055F4")]
	private void RecycleGeneratedMaterials(SkinnedMeshRenderer renderer)
	{
	}

	[Token(Token = "0x60185D0")]
	[Address(RVA = "0x2E05F34", Offset = "0x2E05F34", VA = "0x2E05F34")]
	protected void SetupDynamicBones(bool bforceDyanamic)
	{
	}

	[Token(Token = "0x60185D1")]
	[Address(RVA = "0x2E068C4", Offset = "0x2E068C4", VA = "0x2E068C4")]
	protected void SetupFlux()
	{
	}

	[Token(Token = "0x60185D2")]
	[Address(RVA = "0x2E07648", Offset = "0x2E07648", VA = "0x2E07648")]
	private DynamicBone GetAndRemoveDynamicBone(List<DynamicBone> list, GameObject go, bool net)
	{
		return null;
	}

	[Token(Token = "0x60185D3")]
	[Address(RVA = "0x2E07814", Offset = "0x2E07814", VA = "0x2E07814")]
	protected void FilterDynamicBone(Transform tr, List<Transform> validDynamicBones)
	{
	}

	[Token(Token = "0x60185D4")]
	[Address(RVA = "0x2E079A8", Offset = "0x2E079A8", VA = "0x2E079A8")]
	protected void AddColliderForDynamicBone(DynamicBone db, UMADynamicBoneColliderProperties[] dbcps)
	{
	}

	[Token(Token = "0x60185D5")]
	[Address(RVA = "0x2E07440", Offset = "0x2E07440", VA = "0x2E07440")]
	public Transform FindTransformByName(Transform root, string name)
	{
		return null;
	}

	[Token(Token = "0x60185D6")]
	[Address(RVA = "0x2E07DEC", Offset = "0x2E07DEC", VA = "0x2E07DEC")]
	private void RemoveDirty()
	{
	}

	[Token(Token = "0x60185D7")]
	[Address(RVA = "0x2E07F10", Offset = "0x2E07F10", VA = "0x2E07F10", Slot = "15")]
	public virtual void OnDirtyUpdate()
	{
	}

	[Token(Token = "0x60185D8")]
	[Address(RVA = "0x2E05DF4", Offset = "0x2E05DF4", VA = "0x2E05DF4")]
	private void UpdateUMAMesh(bool updatedAtlas)
	{
	}

	[Token(Token = "0x60185D9")]
	[Address(RVA = "0x2E08278", Offset = "0x2E08278", VA = "0x2E08278", Slot = "4")]
	public override void addDirtyUMA(UMAData umaToAdd)
	{
	}

	[Token(Token = "0x60185DA")]
	[Address(RVA = "0x2E08450", Offset = "0x2E08450", VA = "0x2E08450", Slot = "5")]
	public override bool IsIdle()
	{
		return default(bool);
	}

	[Token(Token = "0x60185DB")]
	[Address(RVA = "0x2E084D8", Offset = "0x2E084D8", VA = "0x2E084D8", Slot = "6")]
	public override int QueueSize()
	{
		return default(int);
	}

	[Token(Token = "0x60185DC")]
	[Address(RVA = "0x2E08550", Offset = "0x2E08550", VA = "0x2E08550", Slot = "16")]
	public virtual bool UMAReady()
	{
		return default(bool);
	}

	[Token(Token = "0x60185DD")]
	[Address(RVA = "0x2E08600", Offset = "0x2E08600", VA = "0x2E08600", Slot = "17")]
	public virtual void UpdateUMABody(UMAData umaData)
	{
	}
}
