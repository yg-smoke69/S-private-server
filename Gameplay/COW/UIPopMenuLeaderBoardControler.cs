using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A71")]
public class UIPopMenuLeaderBoardControler : UIPopMenuSmallControler
{
	[Token(Token = "0x40104AD")]
	[FieldOffset(Offset = "0x64")]
	private Func<FliterData, List<PopMenuData>> DataInjectWithParams;

	[Token(Token = "0x40104AE")]
	[FieldOffset(Offset = "0x68")]
	private FliterData FliterData;

	[Token(Token = "0x601145E")]
	[Address(RVA = "0x2C60204", Offset = "0x2C60204", VA = "0x2C60204")]
	public UIPopMenuLeaderBoardControler()
	{
	}

	[Token(Token = "0x601145F")]
	[Address(RVA = "0x2C60208", Offset = "0x2C60208", VA = "0x2C60208")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011460")]
	[Address(RVA = "0x2C602AC", Offset = "0x2C602AC", VA = "0x2C602AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011461")]
	[Address(RVA = "0x2C6030C", Offset = "0x2C6030C", VA = "0x2C6030C")]
	public void InitPopMenu(Func<FliterData, List<PopMenuData>> injectDataListAction, FliterData fliterData, PopUpStyle style = PopUpStyle.Down, int cellWidth = 260, float maxShowCount = 4.5f, bool enable = true)
	{
	}

	[Token(Token = "0x6011462")]
	[Address(RVA = "0x2C606C0", Offset = "0x2C606C0", VA = "0x2C606C0", Slot = "40")]
	protected override bool CallDataInject()
	{
		return default(bool);
	}

	[Token(Token = "0x6011463")]
	[Address(RVA = "0x2C6081C", Offset = "0x2C6081C", VA = "0x2C6081C")]
	public PopMenuData FindPopMenuData(string fliter)
	{
		return null;
	}

	[Token(Token = "0x6011464")]
	[Address(RVA = "0x2C60AA0", Offset = "0x2C60AA0", VA = "0x2C60AA0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011465")]
	[Address(RVA = "0x2C60AA4", Offset = "0x2C60AA4", VA = "0x2C60AA4")]
	public bool _003C_003EiFixBaseProxy_CallDataInject()
	{
		return default(bool);
	}
}
