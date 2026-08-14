using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200275A")]
internal class UIHudGameOpeningManager : UIBaseController
{
	[Token(Token = "0x200275B")]
	private sealed class _003CShowAnimSprite_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400F30C")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudGameOpeningManager _0024this;

		[Token(Token = "0x400F30D")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400F30E")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400F30F")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170011C4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600F079")]
			[Address(RVA = "0x188A690", Offset = "0x188A690", VA = "0x188A690", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011C5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600F07A")]
			[Address(RVA = "0x188A698", Offset = "0x188A698", VA = "0x188A698", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600F077")]
		[Address(RVA = "0x1889D08", Offset = "0x1889D08", VA = "0x1889D08")]
		public _003CShowAnimSprite_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600F078")]
		[Address(RVA = "0x188A584", Offset = "0x188A584", VA = "0x188A584", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600F07B")]
		[Address(RVA = "0x188A6A0", Offset = "0x188A6A0", VA = "0x188A6A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600F07C")]
		[Address(RVA = "0x188A6B4", Offset = "0x188A6B4", VA = "0x188A6B4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400F2F3")]
	[FieldOffset(Offset = "0x28")]
	public UISprite topBg;

	[Token(Token = "0x400F2F4")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite bottomBg;

	[Token(Token = "0x400F2F5")]
	[FieldOffset(Offset = "0x30")]
	public UILabel mapTxt;

	[Token(Token = "0x400F2F6")]
	[FieldOffset(Offset = "0x34")]
	public UILabel dateTxt;

	[Token(Token = "0x400F2F7")]
	[FieldOffset(Offset = "0x38")]
	public UILabel matchText;

	[Token(Token = "0x400F2F8")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite tweenTopBg;

	[Token(Token = "0x400F2F9")]
	[FieldOffset(Offset = "0x40")]
	private TweenPosition TopTween;

	[Token(Token = "0x400F2FA")]
	[FieldOffset(Offset = "0x44")]
	public UISprite tweenBottomBg;

	[Token(Token = "0x400F2FB")]
	[FieldOffset(Offset = "0x48")]
	private TweenPosition bottomTween;

	[Token(Token = "0x400F2FC")]
	[FieldOffset(Offset = "0x4C")]
	public Transform uiRoot;

	[Token(Token = "0x400F2FD")]
	[FieldOffset(Offset = "0x50")]
	public UISprite baseFrame;

	[Token(Token = "0x400F2FE")]
	[FieldOffset(Offset = "0x54")]
	public UISprite glassesFrame;

	[Token(Token = "0x400F2FF")]
	[FieldOffset(Offset = "0x58")]
	public TweenHeight tweenHeight;

	[Token(Token = "0x400F300")]
	[FieldOffset(Offset = "0x5C")]
	public TweenWidth tweenWidth;

	[Token(Token = "0x400F301")]
	[FieldOffset(Offset = "0x60")]
	public TweenAlpha tweenAlpha;

	[Token(Token = "0x400F302")]
	[FieldOffset(Offset = "0x64")]
	public UISprite[] tweenMask;

	[Token(Token = "0x400F303")]
	[FieldOffset(Offset = "0x68")]
	public GameObject animSprite;

	[Token(Token = "0x400F304")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject startEffect;

	[Token(Token = "0x400F305")]
	[FieldOffset(Offset = "0x70")]
	public GameObject endEffect;

	[Token(Token = "0x400F306")]
	[FieldOffset(Offset = "0x74")]
	public GameObject rankingText;

	[Token(Token = "0x400F307")]
	[FieldOffset(Offset = "0x78")]
	private UILabel[] m_Labels;

	[Token(Token = "0x400F308")]
	[FieldOffset(Offset = "0x7C")]
	private TypewriterEffect[] m_Writers;

	[Token(Token = "0x400F309")]
	[FieldOffset(Offset = "0x80")]
	private int m_WriterIndex;

	[Token(Token = "0x400F30A")]
	[FieldOffset(Offset = "0x84")]
	private uint m_DelayCallId;

	[Token(Token = "0x400F30B")]
	[FieldOffset(Offset = "0x88")]
	private AudioResource m_TypeWriterSound;

	[Token(Token = "0x600F068")]
	[Address(RVA = "0x1888DD0", Offset = "0x1888DD0", VA = "0x1888DD0")]
	public UIHudGameOpeningManager()
	{
	}

	[Token(Token = "0x600F069")]
	[Address(RVA = "0x1888E54", Offset = "0x1888E54", VA = "0x1888E54", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600F06A")]
	[Address(RVA = "0x1889074", Offset = "0x1889074", VA = "0x1889074")]
	private void Start()
	{
	}

	[Token(Token = "0x600F06B")]
	[Address(RVA = "0x18897F0", Offset = "0x18897F0", VA = "0x18897F0", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600F06C")]
	[Address(RVA = "0x18899BC", Offset = "0x18899BC", VA = "0x18899BC")]
	private void Update()
	{
	}

	[Token(Token = "0x600F06D")]
	[Address(RVA = "0x18891AC", Offset = "0x18891AC", VA = "0x18891AC")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x600F06E")]
	[Address(RVA = "0x1889A7C", Offset = "0x1889A7C", VA = "0x1889A7C")]
	private void EnableTypeWriter()
	{
	}

	[Token(Token = "0x600F06F")]
	[Address(RVA = "0x1889C3C", Offset = "0x1889C3C", VA = "0x1889C3C")]
	private IEnumerator ShowAnimSprite()
	{
		return null;
	}

	[Token(Token = "0x600F070")]
	[Address(RVA = "0x1889D10", Offset = "0x1889D10", VA = "0x1889D10")]
	private void ShowTween(object[] data)
	{
	}

	[Token(Token = "0x600F071")]
	[Address(RVA = "0x188A080", Offset = "0x188A080", VA = "0x188A080")]
	public void OnTypeWriterEffectFinished()
	{
	}

	[Token(Token = "0x600F072")]
	[Address(RVA = "0x188A224", Offset = "0x188A224", VA = "0x188A224")]
	private void resizeParticleShapeSize(GameObject effectGo)
	{
	}

	[Token(Token = "0x600F073")]
	[Address(RVA = "0x188A43C", Offset = "0x188A43C", VA = "0x188A43C")]
	private void OnTweenFinish()
	{
	}

	[Token(Token = "0x600F074")]
	[Address(RVA = "0x188A490", Offset = "0x188A490", VA = "0x188A490")]
	private void OnOpeningEnd(object[] data)
	{
	}

	[Token(Token = "0x600F075")]
	[Address(RVA = "0x188A574", Offset = "0x188A574", VA = "0x188A574")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x600F076")]
	[Address(RVA = "0x188A57C", Offset = "0x188A57C", VA = "0x188A57C")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
