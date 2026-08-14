using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200236A")]
public class UIWorkshopDetailController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400DC76")]
	[FieldOffset(Offset = "0x48")]
	private UIWorkshopDetailView m_View;

	[Token(Token = "0x400DC77")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelSceneEdit m_Model;

	[Token(Token = "0x400DC78")]
	[FieldOffset(Offset = "0x50")]
	private UIModelOptionalDownload m_ModelDownload;

	[Token(Token = "0x400DC79")]
	[FieldOffset(Offset = "0x54")]
	private SceneEditSlotInfo m_Info;

	[Token(Token = "0x400DC7A")]
	[FieldOffset(Offset = "0x58")]
	private string m_Code;

	[Token(Token = "0x400DC7B")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_BtnSubscribePos;

	[Token(Token = "0x400DC7C")]
	[FieldOffset(Offset = "0x68")]
	private List<UIWorkshopModeTagController> m_Tags;

	[Token(Token = "0x400DC7D")]
	[FieldOffset(Offset = "0x6C")]
	private List<UIWorkshopTagCommentController> m_Comments;

	[Token(Token = "0x400DC7E")]
	[FieldOffset(Offset = "0x70")]
	private bool m_UGCCommentOpen;

	[Token(Token = "0x400DC7F")]
	[FieldOffset(Offset = "0x74")]
	private EUGCScene m_Scene;

	[Token(Token = "0x400DC80")]
	[FieldOffset(Offset = "0x78")]
	private EOpenWorkshopDetailFrom m_WorkshopDetailWndFrom;

	[Token(Token = "0x400DC81")]
	[FieldOffset(Offset = "0x7C")]
	private int m_WorkshopDetailWndTab;

	[Token(Token = "0x400DC82")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<WorkshopCommentTag> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170010D0")]
	public EOpenWorkshopDetailFrom WorkshopDetailWndFrom
	{
		[Token(Token = "0x600C5AB")]
		[Address(RVA = "0x1A30A24", Offset = "0x1A30A24", VA = "0x1A30A24")]
		get
		{
			return default(EOpenWorkshopDetailFrom);
		}
		[Token(Token = "0x600C5AC")]
		[Address(RVA = "0x1A30A7C", Offset = "0x1A30A7C", VA = "0x1A30A7C")]
		set
		{
		}
	}

	[Token(Token = "0x170010D1")]
	public int WorkshopDetailWndTab
	{
		[Token(Token = "0x600C5AD")]
		[Address(RVA = "0x1A30ADC", Offset = "0x1A30ADC", VA = "0x1A30ADC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600C5AE")]
		[Address(RVA = "0x1A30B34", Offset = "0x1A30B34", VA = "0x1A30B34")]
		set
		{
		}
	}

	[Token(Token = "0x600C59C")]
	[Address(RVA = "0x1A2C284", Offset = "0x1A2C284", VA = "0x1A2C284")]
	public UIWorkshopDetailController()
	{
	}

	[Token(Token = "0x600C59D")]
	[Address(RVA = "0x1A2C28C", Offset = "0x1A2C28C", VA = "0x1A2C28C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C59E")]
	[Address(RVA = "0x1A2C330", Offset = "0x1A2C330", VA = "0x1A2C330", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C59F")]
	[Address(RVA = "0x1A2CBC4", Offset = "0x1A2CBC4", VA = "0x1A2CBC4")]
	private void UpdateCreateRoomBtn()
	{
	}

	[Token(Token = "0x600C5A0")]
	[Address(RVA = "0x1A2CDC8", Offset = "0x1A2CDC8", VA = "0x1A2CDC8")]
	private void UpdateCommentUI()
	{
	}

	[Token(Token = "0x600C5A1")]
	[Address(RVA = "0x1A2D128", Offset = "0x1A2D128", VA = "0x1A2D128", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C5A2")]
	[Address(RVA = "0x1A2D1E0", Offset = "0x1A2D1E0", VA = "0x1A2D1E0", Slot = "34")]
	public override int GlassDelay()
	{
		return default(int);
	}

	[Token(Token = "0x600C5A3")]
	[Address(RVA = "0x1A2D238", Offset = "0x1A2D238", VA = "0x1A2D238")]
	public void SetUIDataBySceneEditSlotInfo(SceneEditSlotInfo info, EUGCScene scene)
	{
	}

	[Token(Token = "0x600C5A4")]
	[Address(RVA = "0x1A2F064", Offset = "0x1A2F064", VA = "0x1A2F064")]
	private void PopCreateRoomWindow()
	{
	}

	[Token(Token = "0x600C5A5")]
	[Address(RVA = "0x1A2F238", Offset = "0x1A2F238", VA = "0x1A2F238")]
	private void OnCopyWorkshopCodeClick()
	{
	}

	[Token(Token = "0x600C5A6")]
	[Address(RVA = "0x1A2F640", Offset = "0x1A2F640", VA = "0x1A2F640")]
	private void OnSubscribeClick()
	{
	}

	[Token(Token = "0x600C5A7")]
	[Address(RVA = "0x1A2FA6C", Offset = "0x1A2FA6C", VA = "0x1A2FA6C")]
	private void OnShareClick()
	{
	}

	[Token(Token = "0x600C5A8")]
	[Address(RVA = "0x1A2FD74", Offset = "0x1A2FD74", VA = "0x1A2FD74")]
	private void OnReportClick()
	{
	}

	[Token(Token = "0x600C5A9")]
	[Address(RVA = "0x1A30044", Offset = "0x1A30044", VA = "0x1A30044")]
	private void OnQuickJoinClick()
	{
	}

	[Token(Token = "0x600C5AA")]
	[Address(RVA = "0x1A3040C", Offset = "0x1A3040C", VA = "0x1A3040C")]
	private void OnCreateRoomClick()
	{
	}

	[Token(Token = "0x600C5AF")]
	[Address(RVA = "0x1A30B94", Offset = "0x1A30B94", VA = "0x1A30B94")]
	private void OnBtnPreviewClick()
	{
	}

	[Token(Token = "0x600C5B0")]
	[Address(RVA = "0x1A30F64", Offset = "0x1A30F64", VA = "0x1A30F64")]
	private void OnFullScreenClick()
	{
	}

	[Token(Token = "0x600C5B1")]
	[Address(RVA = "0x1A31308", Offset = "0x1A31308", VA = "0x1A31308")]
	private void OnAuthorNameClick()
	{
	}

	[Token(Token = "0x600C5B2")]
	[Address(RVA = "0x1A315D0", Offset = "0x1A315D0", VA = "0x1A315D0")]
	private void OnAddCommentClick()
	{
	}

	[Token(Token = "0x600C5B3")]
	[Address(RVA = "0x1A2F418", Offset = "0x1A2F418", VA = "0x1A2F418")]
	private void CopyToClipBoard(string code)
	{
	}

	[Token(Token = "0x600C5B4")]
	[Address(RVA = "0x1A318A4", Offset = "0x1A318A4", VA = "0x1A318A4")]
	private void UpdateSubscribeState()
	{
	}

	[Token(Token = "0x600C5B5")]
	[Address(RVA = "0x1A319D8", Offset = "0x1A319D8", VA = "0x1A319D8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600C5B6")]
	[Address(RVA = "0x1A31CD0", Offset = "0x1A31CD0", VA = "0x1A31CD0", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600C5B7")]
	[Address(RVA = "0x1A31D68", Offset = "0x1A31D68", VA = "0x1A31D68")]
	public void OnBtnMatchMaking()
	{
	}

	[Token(Token = "0x600C5B8")]
	[Address(RVA = "0x1A2E150", Offset = "0x1A2E150", VA = "0x1A2E150")]
	private void RefreshTags(uint[] tagsInfo, uint gameMode)
	{
	}

	[Token(Token = "0x600C5B9")]
	[Address(RVA = "0x1A2E870", Offset = "0x1A2E870", VA = "0x1A2E870")]
	private void RefreshComments()
	{
	}

	[Token(Token = "0x600C5BA")]
	[Address(RVA = "0x1A32814", Offset = "0x1A32814", VA = "0x1A32814")]
	private static int _003CRefreshComments_003Em__0(WorkshopCommentTag a, WorkshopCommentTag b)
	{
		return default(int);
	}

	[Token(Token = "0x600C5BB")]
	[Address(RVA = "0x1A3297C", Offset = "0x1A3297C", VA = "0x1A3297C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C5BC")]
	[Address(RVA = "0x1A32984", Offset = "0x1A32984", VA = "0x1A32984")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600C5BD")]
	[Address(RVA = "0x1A3298C", Offset = "0x1A3298C", VA = "0x1A3298C")]
	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return default(int);
	}
}
