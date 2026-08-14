using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200257F")]
public class UICommonOptionalDownloaderController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E812")]
	private const float CIRCLE_SPEED = 0.2f;

	[Token(Token = "0x400E813")]
	[FieldOffset(Offset = "0x28")]
	private UIModelOptionalDownload m_Model;

	[Token(Token = "0x400E814")]
	[FieldOffset(Offset = "0x2C")]
	private UICommonOptionalDownloaderView m_View;

	[Token(Token = "0x400E815")]
	[FieldOffset(Offset = "0x30")]
	private List<ResourceID> m_NeedDownloadRes;

	[Token(Token = "0x400E816")]
	[FieldOffset(Offset = "0x34")]
	private bool m_ContentShow;

	[Token(Token = "0x600DB44")]
	[Address(RVA = "0x2CE3908", Offset = "0x2CE3908", VA = "0x2CE3908")]
	public UICommonOptionalDownloaderController()
	{
	}

	[Token(Token = "0x600DB45")]
	[Address(RVA = "0x2CE3994", Offset = "0x2CE3994", VA = "0x2CE3994")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DB46")]
	[Address(RVA = "0x2CE3A3C", Offset = "0x2CE3A3C", VA = "0x2CE3A3C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DB47")]
	[Address(RVA = "0x2CE3C64", Offset = "0x2CE3C64", VA = "0x2CE3C64", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DB48")]
	[Address(RVA = "0x2CE3CEC", Offset = "0x2CE3CEC", VA = "0x2CE3CEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600DB49")]
	[Address(RVA = "0x2CE3E48", Offset = "0x2CE3E48", VA = "0x2CE3E48")]
	public void SetData(List<ResourceID> needDownloadList)
	{
	}

	[Token(Token = "0x600DB4A")]
	[Address(RVA = "0x2CE3EA8", Offset = "0x2CE3EA8", VA = "0x2CE3EA8")]
	private void OnControlBtnClick()
	{
	}

	[Token(Token = "0x600DB4B")]
	[Address(RVA = "0x2CE3EFC", Offset = "0x2CE3EFC", VA = "0x2CE3EFC")]
	public void SetButtonShow(bool show)
	{
	}

	[Token(Token = "0x600DB4C")]
	[Address(RVA = "0x2CE3FB4", Offset = "0x2CE3FB4", VA = "0x2CE3FB4", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DB4D")]
	[Address(RVA = "0x2CE4084", Offset = "0x2CE4084", VA = "0x2CE4084", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DB4E")]
	[Address(RVA = "0x2CE4118", Offset = "0x2CE4118", VA = "0x2CE4118")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DB4F")]
	[Address(RVA = "0x2CE4120", Offset = "0x2CE4120", VA = "0x2CE4120")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
