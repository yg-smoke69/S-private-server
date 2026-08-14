using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CDE")]
public class UMAGeneratorCoroutine : WorkerCoroutine
{
	[Token(Token = "0x2003CDF")]
	public class MaterialDefinitionComparer : _Attribute
	{
		[Token(Token = "0x60185EA")]
		[Address(RVA = "0x35DC950", Offset = "0x35DC950", VA = "0x35DC950")]
		public MaterialDefinitionComparer()
		{
		}

		[Token(Token = "0x60185EB")]
		[Address(RVA = "0x35DF8A0", Offset = "0x35DF8A0", VA = "0x35DF8A0", Slot = "4")]
		public int Compare(UMAData.MaterialFragment x, UMAData.MaterialFragment y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2003CE0")]
	private sealed class _003CworkerMethod_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019DC8")]
		[FieldOffset(Offset = "0x8")]
		internal UMAGeneratorCoroutine _0024this;

		[Token(Token = "0x4019DC9")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4019DCA")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4019DCB")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170019BA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60185EE")]
			[Address(RVA = "0x35DF7F4", Offset = "0x35DF7F4", VA = "0x35DF7F4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170019BB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60185EF")]
			[Address(RVA = "0x35DF7FC", Offset = "0x35DF7FC", VA = "0x35DF7FC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60185EC")]
		[Address(RVA = "0x35DE228", Offset = "0x35DE228", VA = "0x35DE228")]
		public _003CworkerMethod_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60185ED")]
		[Address(RVA = "0x35DF29C", Offset = "0x35DF29C", VA = "0x35DF29C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60185F0")]
		[Address(RVA = "0x35DF804", Offset = "0x35DF804", VA = "0x35DF804", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60185F1")]
		[Address(RVA = "0x35DF818", Offset = "0x35DF818", VA = "0x35DF818", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4019DBD")]
	[FieldOffset(Offset = "0x1C")]
	private TextureProcessBaseCoroutine textureProcessCoroutine;

	[Token(Token = "0x4019DBE")]
	[FieldOffset(Offset = "0x20")]
	private MaxRectsBinPack packTexture;

	[Token(Token = "0x4019DBF")]
	[FieldOffset(Offset = "0x24")]
	private UMAGeneratorBase umaGenerator;

	[Token(Token = "0x4019DC0")]
	[FieldOffset(Offset = "0x28")]
	private UMAData umaData;

	[Token(Token = "0x4019DC1")]
	[FieldOffset(Offset = "0x2C")]
	private bool updateMaterialList;

	[Token(Token = "0x4019DC2")]
	[FieldOffset(Offset = "0x30")]
	private int scaleFactor;

	[Token(Token = "0x4019DC3")]
	[FieldOffset(Offset = "0x34")]
	private MaterialDefinitionComparer comparer;

	[Token(Token = "0x4019DC4")]
	[FieldOffset(Offset = "0x38")]
	private List<UMAData.GeneratedMaterial> generatedMaterials;

	[Token(Token = "0x4019DC5")]
	[FieldOffset(Offset = "0x3C")]
	private List<UMAData.GeneratedMaterial> atlassedMaterials;

	[Token(Token = "0x4019DC6")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<List<OverlayData>, UMAData.GeneratedMaterial> generatedMaterialLookup;

	[Token(Token = "0x4019DC7")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<int, List<Material>> recycledMaterials;

	[Token(Token = "0x60185DF")]
	[Address(RVA = "0x35DC89C", Offset = "0x35DC89C", VA = "0x35DC89C")]
	public UMAGeneratorCoroutine()
	{
	}

	[Token(Token = "0x60185E0")]
	[Address(RVA = "0x35DC960", Offset = "0x35DC960", VA = "0x35DC960")]
	public void Prepare(UMAGeneratorBase _umaGenerator, UMAData _umaData, TextureProcessBaseCoroutine textureProcessCoroutine, Dictionary<int, List<Material>> recycledMaterials, bool updateMaterialList, int InitialScaleFactor)
	{
	}

	[Token(Token = "0x60185E1")]
	[Address(RVA = "0x35DC98C", Offset = "0x35DC98C", VA = "0x35DC98C")]
	private UMAData.GeneratedMaterial FindOrCreateGeneratedMaterial(UMAMaterial umaMaterial, bool noFind)
	{
		return null;
	}

	[Token(Token = "0x60185E2")]
	[Address(RVA = "0x35DCFF8", Offset = "0x35DCFF8", VA = "0x35DCFF8", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60185E3")]
	[Address(RVA = "0x35DE1A4", Offset = "0x35DE1A4", VA = "0x35DE1A4", Slot = "5")]
	protected override IEnumerator workerMethod()
	{
		return null;
	}

	[Token(Token = "0x60185E4")]
	[Address(RVA = "0x35DE230", Offset = "0x35DE230", VA = "0x35DE230", Slot = "6")]
	protected override void Stop()
	{
	}

	[Token(Token = "0x60185E5")]
	[Address(RVA = "0x35DE234", Offset = "0x35DE234", VA = "0x35DE234")]
	private void GenerateAtlasData()
	{
	}

	[Token(Token = "0x60185E6")]
	[Address(RVA = "0x35DE9FC", Offset = "0x35DE9FC", VA = "0x35DE9FC")]
	private void UpdateSharedRect(UMAData.GeneratedMaterial generatedMaterial)
	{
	}

	[Token(Token = "0x60185E7")]
	[Address(RVA = "0x35DE480", Offset = "0x35DE480", VA = "0x35DE480")]
	private bool CalculateRects(UMAData.GeneratedMaterial material)
	{
		return default(bool);
	}

	[Token(Token = "0x60185E8")]
	[Address(RVA = "0x35DEB0C", Offset = "0x35DEB0C", VA = "0x35DEB0C")]
	private void OptimizeAtlas()
	{
	}

	[Token(Token = "0x60185E9")]
	[Address(RVA = "0x35DEF44", Offset = "0x35DEF44", VA = "0x35DEF44")]
	private void UpdateUV()
	{
	}
}
