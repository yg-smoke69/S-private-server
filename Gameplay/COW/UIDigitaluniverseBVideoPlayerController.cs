using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;

namespace COW;

[Token(Token = "0x2001F0D")]
public class UIDigitaluniverseBVideoPlayerController : UINavigationController
{
	[Token(Token = "0x2001F0E")]
	private sealed class _003CLoadAndPrepare_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C362")]
		[FieldOffset(Offset = "0x8")]
		internal VideoClip _003Cclip_003E__0;

		[Token(Token = "0x400C363")]
		[FieldOffset(Offset = "0xC")]
		internal UIDigitaluniverseBVideoPlayerController _0024this;

		[Token(Token = "0x400C364")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400C365")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400C366")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000F7C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009842")]
			[Address(RVA = "0x275A064", Offset = "0x275A064", VA = "0x275A064", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F7D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009843")]
			[Address(RVA = "0x275A06C", Offset = "0x275A06C", VA = "0x275A06C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009840")]
		[Address(RVA = "0x2759694", Offset = "0x2759694", VA = "0x2759694")]
		public _003CLoadAndPrepare_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009841")]
		[Address(RVA = "0x27596B4", Offset = "0x27596B4", VA = "0x27596B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009844")]
		[Address(RVA = "0x275A074", Offset = "0x275A074", VA = "0x275A074", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009845")]
		[Address(RVA = "0x275A088", Offset = "0x275A088", VA = "0x275A088", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C35F")]
	[FieldOffset(Offset = "0x68")]
	private RenderTexture renderTexture;

	[Token(Token = "0x400C360")]
	[FieldOffset(Offset = "0x6C")]
	public Action CloseCallBack;

	[Token(Token = "0x400C361")]
	[FieldOffset(Offset = "0x70")]
	private UIDigitaluniverseBVideoView m_View;

	[Token(Token = "0x600982F")]
	[Address(RVA = "0x2757BA4", Offset = "0x2757BA4", VA = "0x2757BA4")]
	public UIDigitaluniverseBVideoPlayerController()
	{
	}

	[Token(Token = "0x6009830")]
	[Address(RVA = "0x2757C28", Offset = "0x2757C28", VA = "0x2757C28")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009831")]
	[Address(RVA = "0x2757CD0", Offset = "0x2757CD0", VA = "0x2757CD0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009832")]
	[Address(RVA = "0x2758010", Offset = "0x2758010", VA = "0x2758010", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6009833")]
	[Address(RVA = "0x2758150", Offset = "0x2758150", VA = "0x2758150")]
	private void OnVideoMaskBtnClick()
	{
	}

	[Token(Token = "0x6009834")]
	[Address(RVA = "0x2758234", Offset = "0x2758234", VA = "0x2758234")]
	private void OnVideoSkipBtnClick()
	{
	}

	[Token(Token = "0x6009835")]
	[Address(RVA = "0x2758540", Offset = "0x2758540", VA = "0x2758540")]
	private void Update()
	{
	}

	[Token(Token = "0x6009836")]
	[Address(RVA = "0x2758404", Offset = "0x2758404", VA = "0x2758404")]
	public void OnPauseVideo(bool paused)
	{
	}

	[Token(Token = "0x6009837")]
	[Address(RVA = "0x2758750", Offset = "0x2758750", VA = "0x2758750", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009838")]
	[Address(RVA = "0x2758A1C", Offset = "0x2758A1C", VA = "0x2758A1C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6009839")]
	[Address(RVA = "0x2758C7C", Offset = "0x2758C7C", VA = "0x2758C7C")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x600983A")]
	[Address(RVA = "0x2758FF0", Offset = "0x2758FF0", VA = "0x2758FF0")]
	public void SetupRenderer()
	{
	}

	[Token(Token = "0x600983B")]
	[Address(RVA = "0x27594C0", Offset = "0x27594C0", VA = "0x27594C0")]
	public bool IsPrePareSuccess()
	{
		return default(bool);
	}

	[Token(Token = "0x600983C")]
	[Address(RVA = "0x2757F44", Offset = "0x2757F44", VA = "0x2757F44")]
	private IEnumerator LoadAndPrepare()
	{
		return null;
	}

	[Token(Token = "0x600983D")]
	[Address(RVA = "0x275969C", Offset = "0x275969C", VA = "0x275969C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600983E")]
	[Address(RVA = "0x27596A4", Offset = "0x27596A4", VA = "0x27596A4")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600983F")]
	[Address(RVA = "0x27596AC", Offset = "0x27596AC", VA = "0x27596AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
