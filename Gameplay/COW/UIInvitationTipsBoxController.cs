using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003361")]
internal class UIInvitationTipsBoxController : UIBaseController
{
	[Token(Token = "0x401391A")]
	[FieldOffset(Offset = "0x28")]
	private UIInvitationTipsBoxView m_View;

	[Token(Token = "0x401391B")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelInvitation m_ModelInvitation;

	[Token(Token = "0x401391C")]
	[FieldOffset(Offset = "0x30")]
	private List<UIInvitationTipsBoxContentController> ContentList;

	[Token(Token = "0x6015D8C")]
	[Address(RVA = "0x12971EC", Offset = "0x12971EC", VA = "0x12971EC")]
	public UIInvitationTipsBoxController()
	{
	}

	[Token(Token = "0x6015D8D")]
	[Address(RVA = "0x12972A4", Offset = "0x12972A4", VA = "0x12972A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015D8E")]
	[Address(RVA = "0x129734C", Offset = "0x129734C", VA = "0x129734C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015D8F")]
	[Address(RVA = "0x1297644", Offset = "0x1297644", VA = "0x1297644", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6015D90")]
	[Address(RVA = "0x12978B0", Offset = "0x12978B0", VA = "0x12978B0")]
	private void HideInvitationTipsBox(object[] args)
	{
	}

	[Token(Token = "0x6015D91")]
	[Address(RVA = "0x12979A8", Offset = "0x12979A8", VA = "0x12979A8")]
	public bool IsInvitationDataOverMaxCnt(object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6015D92")]
	[Address(RVA = "0x1298044", Offset = "0x1298044", VA = "0x1298044")]
	private bool IsfilteredInvitationData(object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6015D93")]
	[Address(RVA = "0x1298228", Offset = "0x1298228", VA = "0x1298228")]
	public void SetUIData()
	{
	}

	[Token(Token = "0x6015D94")]
	[Address(RVA = "0x1298B1C", Offset = "0x1298B1C", VA = "0x1298B1C")]
	private void Expired(object[] args)
	{
	}

	[Token(Token = "0x6015D95")]
	[Address(RVA = "0x1298934", Offset = "0x1298934", VA = "0x1298934")]
	private void ResetContentDepth()
	{
	}

	[Token(Token = "0x6015D96")]
	[Address(RVA = "0x12993A8", Offset = "0x12993A8", VA = "0x12993A8")]
	private bool CheckData(object[] args)
	{
		return default(bool);
	}

	[Token(Token = "0x6015D97")]
	[Address(RVA = "0x129853C", Offset = "0x129853C", VA = "0x129853C")]
	public void GetUIData(out object[] data, out ulong time, out ulong id)
	{
	}

	[Token(Token = "0x6015D98")]
	[Address(RVA = "0x129911C", Offset = "0x129911C", VA = "0x129911C")]
	public void PeekUIData(out object[] data)
	{
	}

	[Token(Token = "0x6015D99")]
	[Address(RVA = "0x1298FD4", Offset = "0x1298FD4", VA = "0x1298FD4")]
	private void OnExpired(object[] args)
	{
	}

	[Token(Token = "0x6015D9A")]
	[Address(RVA = "0x1298868", Offset = "0x1298868", VA = "0x1298868")]
	private void AddContent(UIInvitationTipsBoxContentController content)
	{
	}

	[Token(Token = "0x6015D9B")]
	[Address(RVA = "0x1298F10", Offset = "0x1298F10", VA = "0x1298F10")]
	private void RemoveContent()
	{
	}

	[Token(Token = "0x6015D9C")]
	[Address(RVA = "0x1299E34", Offset = "0x1299E34", VA = "0x1299E34")]
	public void GroupInviteBlock(object[] arg)
	{
	}

	[Token(Token = "0x6015D9D")]
	[Address(RVA = "0x129A048", Offset = "0x129A048", VA = "0x129A048")]
	public void GroupJoinBlock(object[] arg)
	{
	}

	[Token(Token = "0x6015D9E")]
	[Address(RVA = "0x129A25C", Offset = "0x129A25C", VA = "0x129A25C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015D9F")]
	[Address(RVA = "0x129A264", Offset = "0x129A264", VA = "0x129A264")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
