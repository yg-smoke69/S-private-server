using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using message;
using proto;

namespace COW;

[Token(Token = "0x2000AF1")]
public class UIModelSceneEdit_CDNUpload : MonoBehaviour
{
	[Token(Token = "0x2000AF2")]
	private sealed class _003CUploadOneFileWithRetry_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005EF2")]
		[FieldOffset(Offset = "0x8")]
		internal bool _003CisSucc_003E__0;

		[Token(Token = "0x4005EF3")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CretryDuration_003E__0;

		[Token(Token = "0x4005EF4")]
		[FieldOffset(Offset = "0x10")]
		internal int _003CretryCount_003E__0;

		[Token(Token = "0x4005EF5")]
		[FieldOffset(Offset = "0x18")]
		internal double _003CrecordTime_003E__0;

		[Token(Token = "0x4005EF6")]
		[FieldOffset(Offset = "0x20")]
		internal string url;

		[Token(Token = "0x4005EF7")]
		[FieldOffset(Offset = "0x24")]
		internal byte[] data;

		[Token(Token = "0x4005EF8")]
		[FieldOffset(Offset = "0x28")]
		internal UnityWebRequest _003Cwww_003E__1;

		[Token(Token = "0x4005EF9")]
		[FieldOffset(Offset = "0x2C")]
		internal UIModelSceneEdit_CDNUpload _0024this;

		[Token(Token = "0x4005EFA")]
		[FieldOffset(Offset = "0x30")]
		internal object _0024current;

		[Token(Token = "0x4005EFB")]
		[FieldOffset(Offset = "0x34")]
		internal bool _0024disposing;

		[Token(Token = "0x4005EFC")]
		[FieldOffset(Offset = "0x38")]
		internal int _0024PC;

		[Token(Token = "0x170006C4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600542D")]
			[Address(RVA = "0x30E2C14", Offset = "0x30E2C14", VA = "0x30E2C14", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600542E")]
			[Address(RVA = "0x30E2C1C", Offset = "0x30E2C1C", VA = "0x30E2C1C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600542B")]
		[Address(RVA = "0x30E18E4", Offset = "0x30E18E4", VA = "0x30E18E4")]
		public _003CUploadOneFileWithRetry_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600542C")]
		[Address(RVA = "0x30E23F4", Offset = "0x30E23F4", VA = "0x30E23F4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600542F")]
		[Address(RVA = "0x30E2C24", Offset = "0x30E2C24", VA = "0x30E2C24", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005430")]
		[Address(RVA = "0x30E2C38", Offset = "0x30E2C38", VA = "0x30E2C38", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000AF3")]
	private sealed class _003CUpload_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005EFD")]
		[FieldOffset(Offset = "0x8")]
		internal CSGetUploadWorkshopURLRes urlRes;

		[Token(Token = "0x4005EFE")]
		[FieldOffset(Offset = "0xC")]
		internal byte[] runtimeData;

		[Token(Token = "0x4005EFF")]
		[FieldOffset(Offset = "0x10")]
		internal byte[] projectData;

		[Token(Token = "0x4005F00")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelSceneEdit_CDNUpload _0024this;

		[Token(Token = "0x4005F01")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4005F02")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _0024disposing;

		[Token(Token = "0x4005F03")]
		[FieldOffset(Offset = "0x20")]
		internal int _0024PC;

		[Token(Token = "0x170006C6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6005433")]
			[Address(RVA = "0x30E2348", Offset = "0x30E2348", VA = "0x30E2348", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006C7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005434")]
			[Address(RVA = "0x30E2350", Offset = "0x30E2350", VA = "0x30E2350", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005431")]
		[Address(RVA = "0x30E18EC", Offset = "0x30E18EC", VA = "0x30E18EC")]
		public _003CUpload_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6005432")]
		[Address(RVA = "0x30E1F7C", Offset = "0x30E1F7C", VA = "0x30E1F7C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005435")]
		[Address(RVA = "0x30E2358", Offset = "0x30E2358", VA = "0x30E2358", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6005436")]
		[Address(RVA = "0x30E236C", Offset = "0x30E236C", VA = "0x30E236C", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005EEF")]
	[FieldOffset(Offset = "0xC")]
	private PGBGOAOCGDC m_cachedInfo;

	[Token(Token = "0x4005EF0")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsUpdate;

	[Token(Token = "0x4005EF1")]
	[FieldOffset(Offset = "0x14")]
	private string m_lastUploadError;

	[Token(Token = "0x6005423")]
	[Address(RVA = "0x30E1600", Offset = "0x30E1600", VA = "0x30E1600")]
	public UIModelSceneEdit_CDNUpload()
	{
	}

	[Token(Token = "0x6005424")]
	[Address(RVA = "0x30DF8E8", Offset = "0x30DF8E8", VA = "0x30DF8E8")]
	public static UIModelSceneEdit_CDNUpload BeginUpload(PGBGOAOCGDC info, CSGetUploadWorkshopURLRes urlRes, byte[] runtimeData, byte[] projectData, bool update)
	{
		return null;
	}

	[Token(Token = "0x6005425")]
	[Address(RVA = "0x30E17D0", Offset = "0x30E17D0", VA = "0x30E17D0")]
	private IEnumerator UploadOneFileWithRetry(string url, byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6005426")]
	[Address(RVA = "0x30E16A0", Offset = "0x30E16A0", VA = "0x30E16A0")]
	private IEnumerator Upload(CSGetUploadWorkshopURLRes urlRes, byte[] runtimeData, byte[] projectData)
	{
		return null;
	}

	[Token(Token = "0x6005427")]
	[Address(RVA = "0x30E18F4", Offset = "0x30E18F4", VA = "0x30E18F4")]
	private void NotifySucc(long timekey)
	{
	}

	[Token(Token = "0x6005428")]
	[Address(RVA = "0x30E1B80", Offset = "0x30E1B80", VA = "0x30E1B80")]
	private void NotifyFail(CSGetUploadWorkshopURLRes urlRes)
	{
	}

	[Token(Token = "0x6005429")]
	[Address(RVA = "0x30E1CB8", Offset = "0x30E1CB8", VA = "0x30E1CB8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600542A")]
	[Address(RVA = "0x30E1DD4", Offset = "0x30E1DD4", VA = "0x30E1DD4")]
	private void _003CNotifySucc_003Em__0(HttpErrorCode errorCode, object res)
	{
	}
}
