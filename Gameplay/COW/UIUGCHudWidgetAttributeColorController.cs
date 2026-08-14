using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002413")]
public class UIUGCHudWidgetAttributeColorController : UIUGCHudWidgetAttributeController<Color>
{
	[Token(Token = "0x400E0C2")]
	[FieldOffset(Offset = "0x40")]
	private UIUGCHudWidgetAttributeColorView m_View;

	[Token(Token = "0x170010FB")]
	public override Color AttributeData
	{
		[Token(Token = "0x600CBCE")]
		[Address(RVA = "0x2FF4790", Offset = "0x2FF4790", VA = "0x2FF4790", Slot = "36")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Color);
		}
		[Token(Token = "0x600CBCF")]
		[Address(RVA = "0x2FF47FC", Offset = "0x2FF47FC", VA = "0x2FF47FC", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x600CBC9")]
	[Address(RVA = "0x2FF4300", Offset = "0x2FF4300", VA = "0x2FF4300")]
	public UIUGCHudWidgetAttributeColorController()
	{
	}

	[Token(Token = "0x600CBCA")]
	[Address(RVA = "0x2FF4364", Offset = "0x2FF4364", VA = "0x2FF4364")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CBCB")]
	[Address(RVA = "0x2FF4408", Offset = "0x2FF4408", VA = "0x2FF4408", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CBCC")]
	[Address(RVA = "0x2FF4564", Offset = "0x2FF4564", VA = "0x2FF4564", Slot = "31")]
	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return default(UIUGCHudWidgetAttributeEnum);
	}

	[Token(Token = "0x600CBCD")]
	[Address(RVA = "0x2FF45BC", Offset = "0x2FF45BC", VA = "0x2FF45BC", Slot = "38")]
	public override void InitAttribute(Color data)
	{
	}

	[Token(Token = "0x600CBD0")]
	[Address(RVA = "0x2FF48DC", Offset = "0x2FF48DC", VA = "0x2FF48DC")]
	public void SetViewData(string title)
	{
	}

	[Token(Token = "0x600CBD1")]
	[Address(RVA = "0x2FF4974", Offset = "0x2FF4974", VA = "0x2FF4974")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600CBD2")]
	[Address(RVA = "0x2FF4CC4", Offset = "0x2FF4CC4", VA = "0x2FF4CC4")]
	private void _003COnBtnClick_003Em__0(Color value)
	{
	}

	[Token(Token = "0x600CBD3")]
	[Address(RVA = "0x2FF4E40", Offset = "0x2FF4E40", VA = "0x2FF4E40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
