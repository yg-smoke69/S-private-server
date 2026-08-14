using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A3C")]
public class PreviewStoryCgComp : PreviewBaseComponent
{
	[Token(Token = "0x2000A3D")]
	public enum FULLCG
	{
		[Token(Token = "0x4005B66")]
		IceAge = 101,
		[Token(Token = "0x4005B67")]
		BioManiac,
		[Token(Token = "0x4005B68")]
		FlyWing
	}

	[Token(Token = "0x2000A3E")]
	private sealed class _003CSkipCg_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005B69")]
		[FieldOffset(Offset = "0x8")]
		internal PreviewStoryCgComp _0024this;

		[Token(Token = "0x4005B6A")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4005B6B")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4005B6C")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x1700062E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6004FB5")]
			[Address(RVA = "0x19614E0", Offset = "0x19614E0", VA = "0x19614E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700062F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004FB6")]
			[Address(RVA = "0x19614E8", Offset = "0x19614E8", VA = "0x19614E8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0x195F5D8", Offset = "0x195F5D8", VA = "0x195F5D8")]
		public _003CSkipCg_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x196137C", Offset = "0x196137C", VA = "0x196137C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x19614F0", Offset = "0x19614F0", VA = "0x19614F0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x1961504", Offset = "0x1961504", VA = "0x1961504", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005B51")]
	[FieldOffset(Offset = "0x10")]
	private bool m_CgStart;

	[Token(Token = "0x4005B52")]
	[FieldOffset(Offset = "0x14")]
	private GameObject m_CurrentCg;

	[Token(Token = "0x4005B53")]
	[FieldOffset(Offset = "0x18")]
	private Camera m_CurrentCgCamera;

	[Token(Token = "0x4005B54")]
	[FieldOffset(Offset = "0x1C")]
	public Transform CgAnimTrans;

	[Token(Token = "0x4005B55")]
	[FieldOffset(Offset = "0x20")]
	public Transform CGShowUITrans;

	[Token(Token = "0x4005B56")]
	[FieldOffset(Offset = "0x24")]
	public float LastFrame;

	[Token(Token = "0x4005B57")]
	[FieldOffset(Offset = "0x28")]
	public GameObject BgMask;

	[Token(Token = "0x4005B58")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ShowMask;

	[Token(Token = "0x4005B59")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ReturnBtn_LowerLeft;

	[Token(Token = "0x4005B5A")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ReturnBtn_UpperRight;

	[Token(Token = "0x4005B5B")]
	[FieldOffset(Offset = "0x38")]
	private UIButton CurrentButton;

	[Token(Token = "0x4005B5C")]
	[FieldOffset(Offset = "0x3C")]
	private PreviewStoryCgShowUIComp m_previewcomp;

	[Token(Token = "0x4005B5D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsSubtitleBlocked;

	[Token(Token = "0x4005B5E")]
	[FieldOffset(Offset = "0x41")]
	private bool m_IsAudioContinue;

	[Token(Token = "0x4005B5F")]
	[FieldOffset(Offset = "0x44")]
	public UITexture BgPanel;

	[Token(Token = "0x4005B60")]
	[FieldOffset(Offset = "0x48")]
	public Camera m_CurrentBgCamera;

	[Token(Token = "0x4005B61")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<ParticleSystem, MinMaxCurve> m_CGLoopParticleSystemDelayTable;

	[Token(Token = "0x4005B62")]
	[FieldOffset(Offset = "0x50")]
	private uint m_type;

	[Token(Token = "0x4005B63")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsInSkip;

	[Token(Token = "0x4005B64")]
	[FieldOffset(Offset = "0x58")]
	private Action m_callback;

	[Token(Token = "0x1700062B")]
	public uint CurrentType
	{
		[Token(Token = "0x6004F95")]
		[Address(RVA = "0x195D860", Offset = "0x195D860", VA = "0x195D860")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700062C")]
	public Camera CurrentCGCamera
	{
		[Token(Token = "0x6004F96")]
		[Address(RVA = "0x195D8B8", Offset = "0x195D8B8", VA = "0x195D8B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004F97")]
		[Address(RVA = "0x195D910", Offset = "0x195D910", VA = "0x195D910")]
		set
		{
		}
	}

	[Token(Token = "0x1700062D")]
	public GameObject CurrentCG
	{
		[Token(Token = "0x6004F98")]
		[Address(RVA = "0x195D970", Offset = "0x195D970", VA = "0x195D970")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004F99")]
		[Address(RVA = "0x195D9C8", Offset = "0x195D9C8", VA = "0x195D9C8")]
		set
		{
		}
	}

	[Token(Token = "0x6004F94")]
	[Address(RVA = "0x195D84C", Offset = "0x195D84C", VA = "0x195D84C")]
	public PreviewStoryCgComp()
	{
	}

	[Token(Token = "0x6004F9A")]
	[Address(RVA = "0x195DA28", Offset = "0x195DA28", VA = "0x195DA28")]
	public void SetReturnBtnVisble(bool enabled)
	{
	}

	[Token(Token = "0x6004F9B")]
	[Address(RVA = "0x195DACC", Offset = "0x195DACC", VA = "0x195DACC")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6004F9C")]
	[Address(RVA = "0x195E084", Offset = "0x195E084", VA = "0x195E084", Slot = "4")]
	public override void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6004F9D")]
	[Address(RVA = "0x195E108", Offset = "0x195E108", VA = "0x195E108")]
	public void SetCgCameraEnable(bool enabled)
	{
	}

	[Token(Token = "0x6004F9E")]
	[Address(RVA = "0x195E220", Offset = "0x195E220", VA = "0x195E220")]
	private void OnbtnReturn()
	{
	}

	[Token(Token = "0x6004F9F")]
	[Address(RVA = "0x195E6AC", Offset = "0x195E6AC", VA = "0x195E6AC")]
	private void SkipAnim()
	{
	}

	[Token(Token = "0x6004FA0")]
	[Address(RVA = "0x195F50C", Offset = "0x195F50C", VA = "0x195F50C")]
	private IEnumerator SkipCg()
	{
		return null;
	}

	[Token(Token = "0x6004FA1")]
	[Address(RVA = "0x195F5E0", Offset = "0x195F5E0", VA = "0x195F5E0")]
	public bool GetCgInSkip()
	{
		return default(bool);
	}

	[Token(Token = "0x6004FA2")]
	[Address(RVA = "0x195F638", Offset = "0x195F638", VA = "0x195F638")]
	public void ReplayCg()
	{
	}

	[Token(Token = "0x6004FA3")]
	[Address(RVA = "0x195E008", Offset = "0x195E008", VA = "0x195E008")]
	private void ClearMask()
	{
	}

	[Token(Token = "0x6004FA4")]
	[Address(RVA = "0x195FD10", Offset = "0x195FD10", VA = "0x195FD10")]
	public void InitCgConf(ResourceID cgresid, uint uitype, bool isHas, bool isAudioContinue = false, bool showFuncBtn = true)
	{
	}

	[Token(Token = "0x6004FA5")]
	[Address(RVA = "0x1960AAC", Offset = "0x1960AAC", VA = "0x1960AAC")]
	public void PlaySubtitle(object[] data)
	{
	}

	[Token(Token = "0x6004FA6")]
	[Address(RVA = "0x195E8D0", Offset = "0x195E8D0", VA = "0x195E8D0")]
	public void StopSubtitle(object[] data)
	{
	}

	[Token(Token = "0x6004FA7")]
	[Address(RVA = "0x195E280", Offset = "0x195E280", VA = "0x195E280")]
	public void ClearCG()
	{
	}

	[Token(Token = "0x6004FA8")]
	[Address(RVA = "0x19608D0", Offset = "0x19608D0", VA = "0x19608D0")]
	public void PlayCg()
	{
	}

	[Token(Token = "0x6004FA9")]
	[Address(RVA = "0x195E9D0", Offset = "0x195E9D0", VA = "0x195E9D0")]
	private void DispatchEventStoryOver()
	{
	}

	[Token(Token = "0x6004FAA")]
	[Address(RVA = "0x1960E40", Offset = "0x1960E40", VA = "0x1960E40")]
	public void OnCGOver(object[] data)
	{
	}

	[Token(Token = "0x6004FAB")]
	[Address(RVA = "0x1960EC8", Offset = "0x1960EC8", VA = "0x1960EC8")]
	public void StopCg(object[] data)
	{
	}

	[Token(Token = "0x6004FAC")]
	[Address(RVA = "0x195EC78", Offset = "0x195EC78", VA = "0x195EC78")]
	private void SetCgMeshEffect(bool enabled)
	{
	}

	[Token(Token = "0x6004FAD")]
	[Address(RVA = "0x195EE40", Offset = "0x195EE40", VA = "0x195EE40")]
	private void SetPreviewCgSpeed(int speed)
	{
	}

	[Token(Token = "0x6004FAE")]
	[Address(RVA = "0x195F95C", Offset = "0x195F95C", VA = "0x195F95C")]
	private void ResetParticleSystemSpeed()
	{
	}

	[Token(Token = "0x6004FAF")]
	[Address(RVA = "0x19610A8", Offset = "0x19610A8", VA = "0x19610A8")]
	public void SetCallBack(Action callback)
	{
	}

	[Token(Token = "0x6004FB0")]
	[Address(RVA = "0x1960FD4", Offset = "0x1960FD4", VA = "0x1960FD4")]
	private void Executecallback()
	{
	}

	[Token(Token = "0x6004FB1")]
	[Address(RVA = "0x1961108", Offset = "0x1961108", VA = "0x1961108")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004FB2")]
	[Address(RVA = "0x1961374", Offset = "0x1961374", VA = "0x1961374")]
	public void _003C_003EiFixBaseProxy_SetFrontEndPreviewComponent(FrontEndPreviewComponent P0)
	{
	}
}
