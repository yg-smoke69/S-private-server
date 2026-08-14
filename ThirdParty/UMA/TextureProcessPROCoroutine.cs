using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CC0")]
public class TextureProcessPROCoroutine : TextureProcessBaseCoroutine
{
	[Token(Token = "0x2003CC1")]
	private sealed class _003CworkerMethod_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4019CD0")]
		[FieldOffset(Offset = "0x8")]
		internal TextureMerge _003CtextureMerge_003E__0;

		[Token(Token = "0x4019CD1")]
		[FieldOffset(Offset = "0xC")]
		internal int _003CatlasIndex_003E__1;

		[Token(Token = "0x4019CD2")]
		[FieldOffset(Offset = "0x10")]
		internal UMAData.GeneratedMaterial _003Catlas_003E__2;

		[Token(Token = "0x4019CD3")]
		[FieldOffset(Offset = "0x14")]
		internal int _003CmoduleCount_003E__2;

		[Token(Token = "0x4019CD4")]
		[FieldOffset(Offset = "0x18")]
		internal UMAData.MaterialFragment _003CfirstFragment_003E__2;

		[Token(Token = "0x4019CD5")]
		[FieldOffset(Offset = "0x1C")]
		internal SlotData _003CslotData_003E__2;

		[Token(Token = "0x4019CD6")]
		[FieldOffset(Offset = "0x20")]
		internal bool _003CusingRGB565_003E__2;

		[Token(Token = "0x4019CD7")]
		[FieldOffset(Offset = "0x21")]
		internal bool _003Cmerge_003E__2;

		[Token(Token = "0x4019CD8")]
		[FieldOffset(Offset = "0x24")]
		internal int _003CtextureType_003E__3;

		[Token(Token = "0x4019CD9")]
		[FieldOffset(Offset = "0x28")]
		internal UMAMaterial.ChannelType _003CchannelType_003E__4;

		[Token(Token = "0x4019CDA")]
		[FieldOffset(Offset = "0x2C")]
		internal int _003Cwidth_003E__5;

		[Token(Token = "0x4019CDB")]
		[FieldOffset(Offset = "0x30")]
		internal int _003Cheight_003E__5;

		[Token(Token = "0x4019CDC")]
		[FieldOffset(Offset = "0x34")]
		internal bool _003CenableMipMap_003E__5;

		[Token(Token = "0x4019CDD")]
		[FieldOffset(Offset = "0x38")]
		internal float _003CnormalSpecTexScale_003E__5;

		[Token(Token = "0x4019CDE")]
		[FieldOffset(Offset = "0x3C")]
		internal float _003CtexWidthF_003E__5;

		[Token(Token = "0x4019CDF")]
		[FieldOffset(Offset = "0x40")]
		internal float _003CtexHeightF_003E__5;

		[Token(Token = "0x4019CE0")]
		[FieldOffset(Offset = "0x44")]
		internal int _003CtexWidth_003E__5;

		[Token(Token = "0x4019CE1")]
		[FieldOffset(Offset = "0x48")]
		internal int _003CtexHeight_003E__5;

		[Token(Token = "0x4019CE2")]
		[FieldOffset(Offset = "0x4C")]
		internal RenderTextureFormat _003Cformat_003E__5;

		[Token(Token = "0x4019CE3")]
		[FieldOffset(Offset = "0x50")]
		internal Transform _003CcamTransform_003E__5;

		[Token(Token = "0x4019CE4")]
		[FieldOffset(Offset = "0x54")]
		internal Texture2D _003CtempTexture_003E__6;

		[Token(Token = "0x4019CE5")]
		[FieldOffset(Offset = "0x58")]
		internal int _003Cxblocks_003E__6;

		[Token(Token = "0x4019CE6")]
		[FieldOffset(Offset = "0x5C")]
		internal int _003Cyblocks_003E__6;

		[Token(Token = "0x4019CE7")]
		[FieldOffset(Offset = "0x60")]
		internal int _003Cx_003E__7;

		[Token(Token = "0x4019CE8")]
		[FieldOffset(Offset = "0x64")]
		internal int _003Cy_003E__8;

		[Token(Token = "0x4019CE9")]
		[FieldOffset(Offset = "0x68")]
		internal int _003Cx_003E__9;

		[Token(Token = "0x4019CEA")]
		[FieldOffset(Offset = "0x6C")]
		internal int _003Cy_003E__10;

		[Token(Token = "0x4019CEB")]
		[FieldOffset(Offset = "0x70")]
		internal TextureProcessPROCoroutine _0024this;

		[Token(Token = "0x4019CEC")]
		[FieldOffset(Offset = "0x74")]
		internal object _0024current;

		[Token(Token = "0x4019CED")]
		[FieldOffset(Offset = "0x78")]
		internal bool _0024disposing;

		[Token(Token = "0x4019CEE")]
		[FieldOffset(Offset = "0x7C")]
		internal int _0024PC;

		[Token(Token = "0x170019B4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60184F9")]
			[Address(RVA = "0x2DF63A0", Offset = "0x2DF63A0", VA = "0x2DF63A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170019B5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60184FA")]
			[Address(RVA = "0x2DF63A8", Offset = "0x2DF63A8", VA = "0x2DF63A8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60184F7")]
		[Address(RVA = "0x2DF33AC", Offset = "0x2DF33AC", VA = "0x2DF33AC")]
		public _003CworkerMethod_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x60184F8")]
		[Address(RVA = "0x2DF3438", Offset = "0x2DF3438", VA = "0x2DF3438", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60184FB")]
		[Address(RVA = "0x2DF63B0", Offset = "0x2DF63B0", VA = "0x2DF63B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60184FC")]
		[Address(RVA = "0x2DF63C4", Offset = "0x2DF63C4", VA = "0x2DF63C4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4019CC9")]
	[FieldOffset(Offset = "0x1C")]
	private UMAData umaData;

	[Token(Token = "0x4019CCA")]
	[FieldOffset(Offset = "0x20")]
	private RenderTexture destinationTexture;

	[Token(Token = "0x4019CCB")]
	[FieldOffset(Offset = "0x24")]
	private Texture[] resultingTextures;

	[Token(Token = "0x4019CCC")]
	[FieldOffset(Offset = "0x28")]
	private UMAGeneratorBase umaGenerator;

	[Token(Token = "0x4019CCD")]
	[FieldOffset(Offset = "0x2C")]
	private Camera renderCamera;

	[Token(Token = "0x4019CCE")]
	[FieldOffset(Offset = "0x30")]
	private int _alphaMaskID;

	[Token(Token = "0x4019CCF")]
	[FieldOffset(Offset = "0x34")]
	private int _colorEffectParamID;

	[Token(Token = "0x170019B2")]
	private int alphaMaskID
	{
		[Token(Token = "0x60184F0")]
		[Address(RVA = "0x2DF31E4", Offset = "0x2DF31E4", VA = "0x2DF31E4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019B3")]
	private int colorEffectParamID
	{
		[Token(Token = "0x60184F1")]
		[Address(RVA = "0x2DF3258", Offset = "0x2DF3258", VA = "0x2DF3258")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60184EF")]
	[Address(RVA = "0x2DF31DC", Offset = "0x2DF31DC", VA = "0x2DF31DC")]
	public TextureProcessPROCoroutine()
	{
	}

	[Token(Token = "0x60184F2")]
	[Address(RVA = "0x2DF32CC", Offset = "0x2DF32CC", VA = "0x2DF32CC", Slot = "7")]
	public override void Prepare(UMAData _umaData, UMAGeneratorBase _umaGenerator)
	{
	}

	[Token(Token = "0x60184F3")]
	[Address(RVA = "0x2DF3324", Offset = "0x2DF3324", VA = "0x2DF3324", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60184F4")]
	[Address(RVA = "0x2DF3328", Offset = "0x2DF3328", VA = "0x2DF3328", Slot = "5")]
	protected override IEnumerator workerMethod()
	{
		return null;
	}

	[Token(Token = "0x60184F5")]
	[Address(RVA = "0x2DF33B4", Offset = "0x2DF33B4", VA = "0x2DF33B4")]
	private bool IsOpenGL()
	{
		return default(bool);
	}

	[Token(Token = "0x60184F6")]
	[Address(RVA = "0x2DF3434", Offset = "0x2DF3434", VA = "0x2DF3434", Slot = "6")]
	protected override void Stop()
	{
	}
}
