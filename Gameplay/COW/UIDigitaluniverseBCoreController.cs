using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EB6")]
public class UIDigitaluniverseBCoreController : UIBaseController
{
	[Token(Token = "0x2001EB7")]
	private enum ButtonStatus
	{
		[Token(Token = "0x400C156")]
		Idle,
		[Token(Token = "0x400C157")]
		ClickProtect,
		[Token(Token = "0x400C158")]
		Holding,
		[Token(Token = "0x400C159")]
		HoldingWhileAnimOver
	}

	[Token(Token = "0x2001EB8")]
	private sealed class _003CDelayHideLongPressVfx_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C15A")]
		[FieldOffset(Offset = "0x8")]
		internal UIDigitaluniverseBCoreController _0024this;

		[Token(Token = "0x400C15B")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C15C")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C15D")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000F3C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009520")]
			[Address(RVA = "0x2ADBB40", Offset = "0x2ADBB40", VA = "0x2ADBB40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F3D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009521")]
			[Address(RVA = "0x2ADBB48", Offset = "0x2ADBB48", VA = "0x2ADBB48", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600951E")]
		[Address(RVA = "0x2AD97C8", Offset = "0x2AD97C8", VA = "0x2AD97C8")]
		public _003CDelayHideLongPressVfx_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600951F")]
		[Address(RVA = "0x2ADB894", Offset = "0x2ADB894", VA = "0x2ADB894", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009522")]
		[Address(RVA = "0x2ADBB50", Offset = "0x2ADBB50", VA = "0x2ADBB50", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009523")]
		[Address(RVA = "0x2ADBB64", Offset = "0x2ADBB64", VA = "0x2ADBB64", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EB9")]
	private sealed class _003CLighting_003Ec__Iterator1 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C15E")]
		[FieldOffset(Offset = "0x8")]
		internal ulong _003CleftTime_003E__0;

		[Token(Token = "0x400C15F")]
		[FieldOffset(Offset = "0x10")]
		internal UIDigitaluniverseBCoreController _0024this;

		[Token(Token = "0x400C160")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x400C161")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x400C162")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17000F3E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009526")]
			[Address(RVA = "0x2ADBEA4", Offset = "0x2ADBEA4", VA = "0x2ADBEA4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F3F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009527")]
			[Address(RVA = "0x2ADBEAC", Offset = "0x2ADBEAC", VA = "0x2ADBEAC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009524")]
		[Address(RVA = "0x2ADB590", Offset = "0x2ADB590", VA = "0x2ADB590")]
		public _003CLighting_003Ec__Iterator1()
		{
		}

		[Token(Token = "0x6009525")]
		[Address(RVA = "0x2ADBBEC", Offset = "0x2ADBBEC", VA = "0x2ADBBEC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009528")]
		[Address(RVA = "0x2ADBEB4", Offset = "0x2ADBEB4", VA = "0x2ADBEB4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009529")]
		[Address(RVA = "0x2ADBEC8", Offset = "0x2ADBEC8", VA = "0x2ADBEC8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EBA")]
	private sealed class _003CPlayEnterAniamtion_003Ec__Iterator2 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C163")]
		[FieldOffset(Offset = "0x8")]
		internal UIDigitaluniverseBCoreController _0024this;

		[Token(Token = "0x400C164")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400C165")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400C166")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000F40")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600952C")]
			[Address(RVA = "0x2ADC4BC", Offset = "0x2ADC4BC", VA = "0x2ADC4BC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F41")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600952D")]
			[Address(RVA = "0x2ADC4C4", Offset = "0x2ADC4C4", VA = "0x2ADC4C4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600952A")]
		[Address(RVA = "0x2ADB6D4", Offset = "0x2ADB6D4", VA = "0x2ADB6D4")]
		public _003CPlayEnterAniamtion_003Ec__Iterator2()
		{
		}

		[Token(Token = "0x600952B")]
		[Address(RVA = "0x2ADC358", Offset = "0x2ADC358", VA = "0x2ADC358", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600952E")]
		[Address(RVA = "0x2ADC4CC", Offset = "0x2ADC4CC", VA = "0x2ADC4CC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600952F")]
		[Address(RVA = "0x2ADC4E0", Offset = "0x2ADC4E0", VA = "0x2ADC4E0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2001EBB")]
	private sealed class _003CMoveTowardTargetPos_003Ec__Iterator3 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C167")]
		[FieldOffset(Offset = "0x8")]
		internal float _003Cfactor_003E__0;

		[Token(Token = "0x400C168")]
		[FieldOffset(Offset = "0xC")]
		internal Vector2 targetPos;

		[Token(Token = "0x400C169")]
		[FieldOffset(Offset = "0x14")]
		internal float _003Ctime_003E__0;

		[Token(Token = "0x400C16A")]
		[FieldOffset(Offset = "0x18")]
		internal Vector3 _003CstartPos_003E__0;

		[Token(Token = "0x400C16B")]
		[FieldOffset(Offset = "0x24")]
		internal float _003CtotalTime_003E__0;

		[Token(Token = "0x400C16C")]
		[FieldOffset(Offset = "0x28")]
		internal Vector2 _003CcurPos_003E__1;

		[Token(Token = "0x400C16D")]
		[FieldOffset(Offset = "0x30")]
		internal UIDigitaluniverseBCoreController _0024this;

		[Token(Token = "0x400C16E")]
		[FieldOffset(Offset = "0x34")]
		internal object _0024current;

		[Token(Token = "0x400C16F")]
		[FieldOffset(Offset = "0x38")]
		internal bool _0024disposing;

		[Token(Token = "0x400C170")]
		[FieldOffset(Offset = "0x3C")]
		internal int _0024PC;

		[Token(Token = "0x17000F42")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009532")]
			[Address(RVA = "0x2ADC2AC", Offset = "0x2ADC2AC", VA = "0x2ADC2AC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F43")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009533")]
			[Address(RVA = "0x2ADC2B4", Offset = "0x2ADC2B4", VA = "0x2ADC2B4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009530")]
		[Address(RVA = "0x2ADB884", Offset = "0x2ADB884", VA = "0x2ADB884")]
		public _003CMoveTowardTargetPos_003Ec__Iterator3()
		{
		}

		[Token(Token = "0x6009531")]
		[Address(RVA = "0x2ADBF50", Offset = "0x2ADBF50", VA = "0x2ADBF50", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009534")]
		[Address(RVA = "0x2ADC2BC", Offset = "0x2ADC2BC", VA = "0x2ADC2BC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009535")]
		[Address(RVA = "0x2ADC2D0", Offset = "0x2ADC2D0", VA = "0x2ADC2D0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C148")]
	[FieldOffset(Offset = "0x28")]
	private ButtonStatus status;

	[Token(Token = "0x400C149")]
	[FieldOffset(Offset = "0x2C")]
	private CoreNode m_CoreNode;

	[Token(Token = "0x400C14A")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_Position;

	[Token(Token = "0x400C14B")]
	[FieldOffset(Offset = "0x3C")]
	private float m_PressTime;

	[Token(Token = "0x400C14C")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Pressed;

	[Token(Token = "0x400C14D")]
	[FieldOffset(Offset = "0x41")]
	private bool m_CanAssist;

	[Token(Token = "0x400C14E")]
	[FieldOffset(Offset = "0x42")]
	private bool m_IsFirstGuideObj;

	[Token(Token = "0x400C14F")]
	private const string ANIMATIONNAME = "VFX_UIDigitaluniverseBCore_001";

	[Token(Token = "0x400C150")]
	[FieldOffset(Offset = "0x44")]
	private UIDigitaluniverseBCoreInfoPanelController m_InfoPanelCtrl;

	[Token(Token = "0x400C151")]
	[FieldOffset(Offset = "0x48")]
	private UIModelDigitaluniverseB m_DigitaluniverseBModel;

	[Token(Token = "0x400C152")]
	[FieldOffset(Offset = "0x4C")]
	private UIDigitaluniverseBCoreView m_View;

	[Token(Token = "0x400C153")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_LinkSoundObj;

	[Token(Token = "0x400C154")]
	[FieldOffset(Offset = "0x54")]
	private UIDigitaluniverseBGalaxyCanvasController pCtrl;

	[Token(Token = "0x6009506")]
	[Address(RVA = "0x2AD7B94", Offset = "0x2AD7B94", VA = "0x2AD7B94")]
	public UIDigitaluniverseBCoreController()
	{
	}

	[Token(Token = "0x6009507")]
	[Address(RVA = "0x2AD7C18", Offset = "0x2AD7C18", VA = "0x2AD7C18")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009508")]
	[Address(RVA = "0x2AD7CC0", Offset = "0x2AD7CC0", VA = "0x2AD7CC0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009509")]
	[Address(RVA = "0x2AD8248", Offset = "0x2AD8248", VA = "0x2AD8248", Slot = "31")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600950A")]
	[Address(RVA = "0x2AD841C", Offset = "0x2AD841C", VA = "0x2AD841C", Slot = "32")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600950B")]
	[Address(RVA = "0x2AD85F0", Offset = "0x2AD85F0", VA = "0x2AD85F0")]
	public void SetViewData(CoreNode nodeData)
	{
	}

	[Token(Token = "0x600950C")]
	[Address(RVA = "0x2AD8BF8", Offset = "0x2AD8BF8", VA = "0x2AD8BF8")]
	private void RefreshProgressState()
	{
	}

	[Token(Token = "0x600950D")]
	[Address(RVA = "0x2AD8F70", Offset = "0x2AD8F70", VA = "0x2AD8F70")]
	public void RefreshLightenState()
	{
	}

	[Token(Token = "0x600950E")]
	[Address(RVA = "0x2AD918C", Offset = "0x2AD918C", VA = "0x2AD918C")]
	public void ShowPlayerName(bool isShow)
	{
	}

	[Token(Token = "0x600950F")]
	[Address(RVA = "0x2AD9244", Offset = "0x2AD9244", VA = "0x2AD9244")]
	private void HideHoldUI(bool isPressFinished = false)
	{
	}

	[Token(Token = "0x6009510")]
	[Address(RVA = "0x2AD96FC", Offset = "0x2AD96FC", VA = "0x2AD96FC")]
	private IEnumerator DelayHideLongPressVfx()
	{
		return null;
	}

	[Token(Token = "0x6009511")]
	[Address(RVA = "0x2AD97D0", Offset = "0x2AD97D0", VA = "0x2AD97D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6009512")]
	[Address(RVA = "0x2ADABFC", Offset = "0x2ADABFC", VA = "0x2ADABFC")]
	private void onPressCoreBtn()
	{
	}

	[Token(Token = "0x6009513")]
	[Address(RVA = "0x2ADAC58", Offset = "0x2ADAC58", VA = "0x2ADAC58")]
	private void onReleaseCoreBtn()
	{
	}

	[Token(Token = "0x6009514")]
	[Address(RVA = "0x2ADACB4", Offset = "0x2ADACB4", VA = "0x2ADACB4")]
	private void OnBgDrag(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x6009515")]
	[Address(RVA = "0x2ADB2F4", Offset = "0x2ADB2F4", VA = "0x2ADB2F4")]
	private void OnPressCoreGuide(object[] data)
	{
	}

	[Token(Token = "0x6009516")]
	[Address(RVA = "0x2ADB440", Offset = "0x2ADB440", VA = "0x2ADB440")]
	private void OnTabCoreGuide(object[] data)
	{
	}

	[Token(Token = "0x6009517")]
	[Address(RVA = "0x2ADB500", Offset = "0x2ADB500", VA = "0x2ADB500")]
	public void OnCancleCoreSelected()
	{
	}

	[Token(Token = "0x6009518")]
	[Address(RVA = "0x2AD90C0", Offset = "0x2AD90C0", VA = "0x2AD90C0")]
	private IEnumerator Lighting()
	{
		return null;
	}

	[Token(Token = "0x6009519")]
	[Address(RVA = "0x2ADB598", Offset = "0x2ADB598", VA = "0x2ADB598")]
	public Transform GetAnimationCtrl()
	{
		return null;
	}

	[Token(Token = "0x600951A")]
	[Address(RVA = "0x2ADB608", Offset = "0x2ADB608", VA = "0x2ADB608")]
	public IEnumerator PlayEnterAniamtion()
	{
		return null;
	}

	[Token(Token = "0x600951B")]
	[Address(RVA = "0x2ADB6DC", Offset = "0x2ADB6DC", VA = "0x2ADB6DC")]
	public void PlayMoveAnimation(Vector2 targetPos)
	{
	}

	[Token(Token = "0x600951C")]
	[Address(RVA = "0x2ADB774", Offset = "0x2ADB774", VA = "0x2ADB774")]
	private IEnumerator MoveTowardTargetPos(Vector2 targetPos)
	{
		return null;
	}

	[Token(Token = "0x600951D")]
	[Address(RVA = "0x2ADB88C", Offset = "0x2ADB88C", VA = "0x2ADB88C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
