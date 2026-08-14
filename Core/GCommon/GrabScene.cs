using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace GCommon;

[Token(Token = "0x2000008")]
public class GrabScene : MonoBehaviour
{
	[Token(Token = "0x2000009")]
	public enum DownSampling
	{
		[Token(Token = "0x4000051")]
		none = 1,
		[Token(Token = "0x4000052")]
		half = 2,
		[Token(Token = "0x4000053")]
		quarter = 4,
		[Token(Token = "0x4000054")]
		oneEighth = 8
	}

	[Token(Token = "0x200000A")]
	public enum UsedCamera
	{
		[Token(Token = "0x4000056")]
		BGCamera,
		[Token(Token = "0x4000057")]
		MainCamera,
		[Token(Token = "0x4000058")]
		UICamera,
		[Token(Token = "0x4000059")]
		TotalCount
	}

	[Token(Token = "0x200000B")]
	private sealed class _003CCaptureScene_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x8")]
		internal GrabScene _0024this;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000001")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x32B81A0", Offset = "0x32B81A0", VA = "0x32B81A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x32B81A8", Offset = "0x32B81A8", VA = "0x32B81A8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x32B6B84", Offset = "0x32B6B84", VA = "0x32B6B84")]
		public _003CCaptureScene_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x32B7EB0", Offset = "0x32B7EB0", VA = "0x32B7EB0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x32B81B0", Offset = "0x32B81B0", VA = "0x32B81B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x32B81B4", Offset = "0x32B81B4", VA = "0x32B81B4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0xC")]
	private bool m_IsReady;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x10")]
	public DownSampling Quality;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x14")]
	public UsedCamera UseCamera;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x18")]
	public bool FullScreen;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x19")]
	public bool UseTextureOriginAlpha;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x1C")]
	public Renderer m_Renderer;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x20")]
	public UITexture m_UITexture;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x24")]
	public bool IgnoreFirstEnable;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x25")]
	private bool m_CommandBufferAndCameraInited;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x28")]
	private Camera[] m_Cameras;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x2C")]
	private int rtW;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x30")]
	private int rtH;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x34")]
	private bool m_ForceInToRenderTexture;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x38")]
	private CommandBuffer m_CommandBuffer;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x3C")]
	private RenderTexture m_CaptureTexture;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x40")]
	private bool m_UpdateCommandBuffer;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<UICOWBaseScene.WaitFor, UICOWBaseScene.Wait> m_Waits;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x32B599C", Offset = "0x32B599C", VA = "0x32B599C")]
	public GrabScene()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x32B5A40", Offset = "0x32B5A40", VA = "0x32B5A40")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x32B5D8C", Offset = "0x32B5D8C", VA = "0x32B5D8C")]
	private bool Init()
	{
		return default(bool);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x32B67D0", Offset = "0x32B67D0", VA = "0x32B67D0")]
	private void SetFullScreen()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x32B674C", Offset = "0x32B674C", VA = "0x32B674C")]
	private IEnumerator CaptureScene()
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x32B6B8C", Offset = "0x32B6B8C", VA = "0x32B6B8C")]
	private void OnCameraPreRender(Camera cam)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x32B6F54", Offset = "0x32B6F54", VA = "0x32B6F54")]
	private void OnCameraPostRender(Camera cam)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x32B7134", Offset = "0x32B7134", VA = "0x32B7134")]
	private void CleanCommandBuffer()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x32B7524", Offset = "0x32B7524", VA = "0x32B7524")]
	private void HideWaits()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x32B7714", Offset = "0x32B7714", VA = "0x32B7714")]
	private void ShowWaits()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x32B71CC", Offset = "0x32B71CC", VA = "0x32B71CC")]
	public void GetFrameToTexture()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x32B7930", Offset = "0x32B7930", VA = "0x32B7930")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x32B7E6C", Offset = "0x32B7E6C", VA = "0x32B7E6C")]
	private void OnDestroy()
	{
	}
}
