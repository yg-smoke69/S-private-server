using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002420")]
public class UIUGCHudWidgetAttributeTransformItemController : UIBaseController
{
	[Token(Token = "0x2002421")]
	public enum TransformEnum
	{
		[Token(Token = "0x400E0E5")]
		X,
		[Token(Token = "0x400E0E6")]
		Y,
		[Token(Token = "0x400E0E7")]
		Width,
		[Token(Token = "0x400E0E8")]
		Height,
		[Token(Token = "0x400E0E9")]
		Angle
	}

	[Token(Token = "0x400E0E0")]
	[FieldOffset(Offset = "0x28")]
	private UIUGCHudWidgetAttributeTransformItemView m_View;

	[Token(Token = "0x400E0E1")]
	[FieldOffset(Offset = "0x2C")]
	private int m_CurrentValue;

	[Token(Token = "0x400E0E2")]
	[FieldOffset(Offset = "0x30")]
	private TransformEnum m_TransformEnum;

	[Token(Token = "0x400E0E3")]
	[FieldOffset(Offset = "0x34")]
	public Action onValueChanged;

	[Token(Token = "0x17001104")]
	public int Value
	{
		[Token(Token = "0x600CC54")]
		[Address(RVA = "0x2FFCD98", Offset = "0x2FFCD98", VA = "0x2FFCD98")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600CC55")]
		[Address(RVA = "0x2FFDD7C", Offset = "0x2FFDD7C", VA = "0x2FFDD7C")]
		set
		{
		}
	}

	[Token(Token = "0x600CC51")]
	[Address(RVA = "0x2FFD888", Offset = "0x2FFD888", VA = "0x2FFD888")]
	public UIUGCHudWidgetAttributeTransformItemController()
	{
	}

	[Token(Token = "0x600CC52")]
	[Address(RVA = "0x2FFD90C", Offset = "0x2FFD90C", VA = "0x2FFD90C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CC53")]
	[Address(RVA = "0x2FFD9B0", Offset = "0x2FFD9B0", VA = "0x2FFD9B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CC56")]
	[Address(RVA = "0x2FFC0C4", Offset = "0x2FFC0C4", VA = "0x2FFC0C4")]
	public void SetTransformEnum(TransformEnum transformEnum)
	{
	}

	[Token(Token = "0x600CC57")]
	[Address(RVA = "0x2FFC058", Offset = "0x2FFC058", VA = "0x2FFC058")]
	public void SetData(int cur)
	{
	}

	[Token(Token = "0x600CC58")]
	[Address(RVA = "0x2FFDE08", Offset = "0x2FFDE08", VA = "0x2FFDE08")]
	private void RefreshContent()
	{
	}

	[Token(Token = "0x600CC59")]
	[Address(RVA = "0x2FFDEC4", Offset = "0x2FFDEC4", VA = "0x2FFDEC4")]
	private void OnMinusBtnClick()
	{
	}

	[Token(Token = "0x600CC5A")]
	[Address(RVA = "0x2FFDF30", Offset = "0x2FFDF30", VA = "0x2FFDF30")]
	private void OnAddBtnClick()
	{
	}

	[Token(Token = "0x600CC5B")]
	[Address(RVA = "0x2FFDF9C", Offset = "0x2FFDF9C", VA = "0x2FFDF9C")]
	private void OnInputChanged()
	{
	}

	[Token(Token = "0x600CC5C")]
	[Address(RVA = "0x2FFDFF0", Offset = "0x2FFDFF0", VA = "0x2FFDFF0")]
	private void OnInputSubmit()
	{
	}

	[Token(Token = "0x600CC5D")]
	[Address(RVA = "0x2FFE0AC", Offset = "0x2FFE0AC", VA = "0x2FFE0AC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
