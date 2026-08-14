using Il2CppDummyDll;
using UnityEngine.UI;

namespace ReactUI;

[Token(Token = "0x2000CDC")]
public sealed class UIVariableBindSlider : UIVariableBind
{
	[Token(Token = "0x2000CDD")]
	public enum TweenType
	{
		[Token(Token = "0x4006846")]
		IncreaseOnly,
		[Token(Token = "0x4006847")]
		DecreaseOnly,
		[Token(Token = "0x4006848")]
		DoubleWay
	}

	[Token(Token = "0x400683E")]
	[FieldOffset(Offset = "0x1C")]
	private string valueBind;

	[Token(Token = "0x400683F")]
	[FieldOffset(Offset = "0x20")]
	private float tweenSpeed;

	[Token(Token = "0x4006840")]
	[FieldOffset(Offset = "0x24")]
	private TweenType tweenType;

	[Token(Token = "0x4006841")]
	[FieldOffset(Offset = "0x28")]
	private Slider m_slider;

	[Token(Token = "0x4006842")]
	[FieldOffset(Offset = "0x2C")]
	private UIVariable m_sliderVariable;

	[Token(Token = "0x4006843")]
	[FieldOffset(Offset = "0x30")]
	private float m_targetSliderValue;

	[Token(Token = "0x4006844")]
	[FieldOffset(Offset = "0x34")]
	private bool m_isInTween;

	[Token(Token = "0x1700081E")]
	public float TweenSpeed
	{
		[Token(Token = "0x600619D")]
		[Address(RVA = "0x31674E0", Offset = "0x31674E0", VA = "0x31674E0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600619E")]
		[Address(RVA = "0x31674E8", Offset = "0x31674E8", VA = "0x31674E8")]
		set
		{
		}
	}

	[Token(Token = "0x600619C")]
	[Address(RVA = "0x316745C", Offset = "0x316745C", VA = "0x316745C")]
	public UIVariableBindSlider()
	{
	}

	[Token(Token = "0x600619F")]
	[Address(RVA = "0x31674F0", Offset = "0x31674F0", VA = "0x31674F0", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x60061A0")]
	[Address(RVA = "0x31677F8", Offset = "0x31677F8", VA = "0x31677F8", Slot = "7")]
	protected override void UnbindVariables()
	{
	}

	[Token(Token = "0x60061A1")]
	[Address(RVA = "0x31676A0", Offset = "0x31676A0", VA = "0x31676A0")]
	private void InitSliderValue()
	{
	}

	[Token(Token = "0x60061A2")]
	[Address(RVA = "0x3167908", Offset = "0x3167908", VA = "0x3167908")]
	private void RefreshSliderValue()
	{
	}

	[Token(Token = "0x60061A3")]
	[Address(RVA = "0x3167A8C", Offset = "0x3167A8C", VA = "0x3167A8C")]
	private void Update()
	{
	}

	[Token(Token = "0x60061A4")]
	[Address(RVA = "0x3167BBC", Offset = "0x3167BBC", VA = "0x3167BBC")]
	private void TweenIncrease()
	{
	}

	[Token(Token = "0x60061A5")]
	[Address(RVA = "0x3167D08", Offset = "0x3167D08", VA = "0x3167D08")]
	private void TweenDecrease()
	{
	}

	[Token(Token = "0x60061A6")]
	[Address(RVA = "0x3167E54", Offset = "0x3167E54", VA = "0x3167E54")]
	private void TweenAll()
	{
	}

	[Token(Token = "0x60061A7")]
	[Address(RVA = "0x3167FD4", Offset = "0x3167FD4", VA = "0x3167FD4")]
	private new void Awake()
	{
	}
}
