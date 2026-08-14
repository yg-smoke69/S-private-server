using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using proto;

namespace COW;

[Token(Token = "0x2000AEB")]
public class UIModelSceneEdit_CDNDownLoad : MonoBehaviour
{
	[Token(Token = "0x2000AEC")]
	public enum EDownLoadType
	{
		[Token(Token = "0x4005ED8")]
		WorkShop,
		[Token(Token = "0x4005ED9")]
		PreviewWorkShop
	}

	[Token(Token = "0x2000AED")]
	private delegate void DownLoadSuccess(byte[] b);

	[Token(Token = "0x2000AEE")]
	private sealed class _003CDownLoadOneFileWithRetry_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005EDA")]
		[FieldOffset(Offset = "0x8")]
		internal bool _003CisSucc_003E__0;

		[Token(Token = "0x4005EDB")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CretryDuration_003E__0;

		[Token(Token = "0x4005EDC")]
		[FieldOffset(Offset = "0x10")]
		internal int _003CretryCount_003E__0;

		[Token(Token = "0x4005EDD")]
		[FieldOffset(Offset = "0x18")]
		internal double _003CrecordTime_003E__0;

		[Token(Token = "0x4005EDE")]
		[FieldOffset(Offset = "0x20")]
		internal string url;

		[Token(Token = "0x4005EDF")]
		[FieldOffset(Offset = "0x24")]
		internal UnityWebRequest _003Cwww_003E__1;

		[Token(Token = "0x4005EE0")]
		[FieldOffset(Offset = "0x28")]
		internal DownLoadSuccess suc;

		[Token(Token = "0x4005EE1")]
		[FieldOffset(Offset = "0x2C")]
		internal UIModelSceneEdit_CDNDownLoad _0024this;

		[Token(Token = "0x4005EE2")]
		[FieldOffset(Offset = "0x30")]
		internal object _0024current;

		[Token(Token = "0x4005EE3")]
		[FieldOffset(Offset = "0x34")]
		internal bool _0024disposing;

		[Token(Token = "0x4005EE4")]
		[FieldOffset(Offset = "0x38")]
		internal int _0024PC;

		[Token(Token = "0x170006C0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005416")]
			[Address(RVA = "0x30E151C", Offset = "0x30E151C", VA = "0x30E151C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005417")]
			[Address(RVA = "0x30E1524", Offset = "0x30E1524", VA = "0x30E1524", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005414")]
		[Address(RVA = "0x30DFE3C", Offset = "0x30DFE3C", VA = "0x30DFE3C")]
		public _003CDownLoadOneFileWithRetry_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6005415")]
		[Address(RVA = "0x30E0A08", Offset = "0x30E0A08", VA = "0x30E0A08", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005418")]
		[Address(RVA = "0x30E152C", Offset = "0x30E152C", VA = "0x30E152C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005419")]
		[Address(RVA = "0x30E1540", Offset = "0x30E1540", VA = "0x30E1540", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000AEF")]
	private sealed class _003CDownLoad_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x2000AF0")]
		private sealed class _003CDownLoad_003Ec__AnonStorey2
		{
			[Token(Token = "0x4005EEC")]
			[FieldOffset(Offset = "0x8")]
			internal byte[] projectBytes;

			[Token(Token = "0x4005EED")]
			[FieldOffset(Offset = "0xC")]
			internal byte[] exportBytes;

			[Token(Token = "0x4005EEE")]
			[FieldOffset(Offset = "0x10")]
			internal _003CDownLoad_003Ec__Iterator1 _003C_003Ef__ref_00241;

			[Token(Token = "0x6005420")]
			[Address(RVA = "0x30E0930", Offset = "0x30E0930", VA = "0x30E0930")]
			public _003CDownLoad_003Ec__AnonStorey2()
			{
			}

			[Token(Token = "0x6005421")]
			[Address(RVA = "0x30E09F8", Offset = "0x30E09F8", VA = "0x30E09F8")]
			internal void _003C_003Em__0(byte[] downLoadBytes)
			{
			}

			[Token(Token = "0x6005422")]
			[Address(RVA = "0x30E0A00", Offset = "0x30E0A00", VA = "0x30E0A00")]
			internal void _003C_003Em__1(byte[] downLoadBytes)
			{
			}
		}

		[Token(Token = "0x4005EE5")]
		[FieldOffset(Offset = "0x8")]
		internal string _003CprojectUrl_003E__0;

		[Token(Token = "0x4005EE6")]
		[FieldOffset(Offset = "0xC")]
		internal string _003CexportUrl_003E__0;

		[Token(Token = "0x4005EE7")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelSceneEdit_CDNDownLoad _0024this;

		[Token(Token = "0x4005EE8")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4005EE9")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x4005EEA")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x4005EEB")]
		[FieldOffset(Offset = "0x20")]
		private _003CDownLoad_003Ec__AnonStorey2 _0024locvar1;

		[Token(Token = "0x170006C2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600541C")]
			[Address(RVA = "0x30E094C", Offset = "0x30E094C", VA = "0x30E094C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600541D")]
			[Address(RVA = "0x30E0954", Offset = "0x30E0954", VA = "0x30E0954", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600541A")]
		[Address(RVA = "0x30DFE44", Offset = "0x30DFE44", VA = "0x30DFE44")]
		public _003CDownLoad_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x600541B")]
		[Address(RVA = "0x30E03CC", Offset = "0x30E03CC", VA = "0x30E03CC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600541E")]
		[Address(RVA = "0x30E095C", Offset = "0x30E095C", VA = "0x30E095C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600541F")]
		[Address(RVA = "0x30E0970", Offset = "0x30E0970", VA = "0x30E0970", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005ECD")]
	[FieldOffset(Offset = "0xC")]
	public EDownLoadType downLoadType;

	[Token(Token = "0x4005ECE")]
	[FieldOffset(Offset = "0x10")]
	public EWorkshop.SlotType curSlotType;

	[Token(Token = "0x4005ECF")]
	[FieldOffset(Offset = "0x14")]
	public uint curSlotID;

	[Token(Token = "0x4005ED0")]
	[FieldOffset(Offset = "0x18")]
	public uint dstSlotID;

	[Token(Token = "0x4005ED1")]
	[FieldOffset(Offset = "0x1C")]
	public CSDownloadWorkshopRes workShopUrlRes;

	[Token(Token = "0x4005ED2")]
	[FieldOffset(Offset = "0x20")]
	public UIModelSceneEdit.EWorkshopDownloadType workshopDownloadType;

	[Token(Token = "0x4005ED3")]
	[FieldOffset(Offset = "0x24")]
	public CSPreviewWorkshopCodeRes previewUrlRes;

	[Token(Token = "0x4005ED4")]
	[FieldOffset(Offset = "0x28")]
	public string code;

	[Token(Token = "0x4005ED5")]
	[FieldOffset(Offset = "0x2C")]
	private string m_lastDownLoadError;

	[Token(Token = "0x4005ED6")]
	[FieldOffset(Offset = "0x30")]
	public float downloadTimeElapsed;

	[Token(Token = "0x6005407")]
	[Address(RVA = "0x30DFBB8", Offset = "0x30DFBB8", VA = "0x30DFBB8")]
	public UIModelSceneEdit_CDNDownLoad()
	{
	}

	[Token(Token = "0x6005408")]
	[Address(RVA = "0x30DCB2C", Offset = "0x30DCB2C", VA = "0x30DCB2C")]
	public static UIModelSceneEdit_CDNDownLoad BeginDownLoad(CSDownloadWorkshopRes urlRes, UIModelSceneEdit.EWorkshopDownloadType downloadType, EWorkshop.SlotType type, uint slotID, uint destId)
	{
		return null;
	}

	[Token(Token = "0x6005409")]
	[Address(RVA = "0x30DD894", Offset = "0x30DD894", VA = "0x30DD894")]
	public static UIModelSceneEdit_CDNDownLoad BeginDownLoad(CSPreviewWorkshopCodeRes urlRes, string code)
	{
		return null;
	}

	[Token(Token = "0x600540A")]
	[Address(RVA = "0x30DFD24", Offset = "0x30DFD24", VA = "0x30DFD24")]
	private IEnumerator DownLoadOneFileWithRetry(string url, DownLoadSuccess suc)
	{
		return null;
	}

	[Token(Token = "0x600540B")]
	[Address(RVA = "0x30DFC58", Offset = "0x30DFC58", VA = "0x30DFC58")]
	private IEnumerator DownLoad()
	{
		return null;
	}

	[Token(Token = "0x600540C")]
	[Address(RVA = "0x30DFE4C", Offset = "0x30DFE4C", VA = "0x30DFE4C")]
	private void NotifySucc(byte[] projectBytes, byte[] runtimeBytes)
	{
	}

	[Token(Token = "0x600540D")]
	[Address(RVA = "0x30E0008", Offset = "0x30E0008", VA = "0x30E0008")]
	private void NotifyFail()
	{
	}

	[Token(Token = "0x600540E")]
	[Address(RVA = "0x30E0130", Offset = "0x30E0130", VA = "0x30E0130")]
	private void Update()
	{
	}

	[Token(Token = "0x600540F")]
	[Address(RVA = "0x30E02B0", Offset = "0x30E02B0", VA = "0x30E02B0")]
	private void OnDestroy()
	{
	}
}
