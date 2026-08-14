using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002449")]
internal class UIHUDUGC_CheckPointMgrController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E182")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_CheckPointMgrView m_View;

	[Token(Token = "0x400E183")]
	[FieldOffset(Offset = "0x2C")]
	private CheckPointMgrHudEntity m_ViewData;

	[Token(Token = "0x400E184")]
	[FieldOffset(Offset = "0x30")]
	private UIInGameScene m_GameScene;

	[Token(Token = "0x400E185")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<int, UIHUDUGC_CheckPointMarkShowController> m_CheckPointDict;

	[Token(Token = "0x400E186")]
	[FieldOffset(Offset = "0x38")]
	private List<UIHUDUGC_CheckPointMarkShowController> m_EndPointList;

	[Token(Token = "0x400E187")]
	private const int CONST_FirstCheckPointID = 1;

	[Token(Token = "0x400E188")]
	[FieldOffset(Offset = "0x3C")]
	private string m_EntityID;

	[Token(Token = "0x400E189")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsInit;

	[Token(Token = "0x600CDE9")]
	[Address(RVA = "0x2227194", Offset = "0x2227194", VA = "0x2227194")]
	public UIHUDUGC_CheckPointMgrController()
	{
	}

	[Token(Token = "0x600CDEA")]
	[Address(RVA = "0x2227280", Offset = "0x2227280", VA = "0x2227280")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CDEB")]
	[Address(RVA = "0x2227324", Offset = "0x2227324", VA = "0x2227324", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CDEC")]
	[Address(RVA = "0x2227C64", Offset = "0x2227C64", VA = "0x2227C64", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CDED")]
	[Address(RVA = "0x22281C8", Offset = "0x22281C8", VA = "0x22281C8")]
	protected void OnPlayerLastCheckPointIDChange(object[] data)
	{
	}

	[Token(Token = "0x600CDEE")]
	[Address(RVA = "0x222844C", Offset = "0x222844C", VA = "0x222844C")]
	protected void OnPlayerNextCheckPointIDChange(object[] data)
	{
	}

	[Token(Token = "0x600CDEF")]
	[Address(RVA = "0x22275E8", Offset = "0x22275E8", VA = "0x22275E8")]
	protected void ProcessPlayerCurCheckPointIDChange(int oldID, int newID)
	{
	}

	[Token(Token = "0x600CDF0")]
	[Address(RVA = "0x2227918", Offset = "0x2227918", VA = "0x2227918")]
	protected void ProcessPlayerNextCheckPointIDChange(int oldID, int newID)
	{
	}

	[Token(Token = "0x600CDF1")]
	[Address(RVA = "0x222897C", Offset = "0x222897C", VA = "0x222897C")]
	private void ShowEndPoints()
	{
	}

	[Token(Token = "0x600CDF2")]
	[Address(RVA = "0x2228F44", Offset = "0x2228F44", VA = "0x2228F44")]
	private void HideEndPoints()
	{
	}

	[Token(Token = "0x600CDF3")]
	[Address(RVA = "0x2228C60", Offset = "0x2228C60", VA = "0x2228C60")]
	private void AddCheckPointHud(int index)
	{
	}

	[Token(Token = "0x600CDF4")]
	[Address(RVA = "0x22286D0", Offset = "0x22286D0", VA = "0x22286D0")]
	private void RemoveCheckPointHud(int index)
	{
	}

	[Token(Token = "0x600CDF5")]
	[Address(RVA = "0x222923C", Offset = "0x222923C", VA = "0x222923C")]
	private UGCLevelCheckPoint GetCheckPoint(int id)
	{
		return null;
	}

	[Token(Token = "0x600CDF6")]
	[Address(RVA = "0x2228890", Offset = "0x2228890", VA = "0x2228890")]
	private int GetCheckPointCount()
	{
		return default(int);
	}

	[Token(Token = "0x600CDF7")]
	[Address(RVA = "0x2229150", Offset = "0x2229150", VA = "0x2229150")]
	private Dictionary<uint, BaseLevelObject> GetAllEndPoints()
	{
		return null;
	}

	[Token(Token = "0x600CDF8")]
	[Address(RVA = "0x2229380", Offset = "0x2229380", VA = "0x2229380", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CDF9")]
	[Address(RVA = "0x2228154", Offset = "0x2228154", VA = "0x2228154", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CDFA")]
	[Address(RVA = "0x22294A0", Offset = "0x22294A0", VA = "0x22294A0")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CDFB")]
	[Address(RVA = "0x2229848", Offset = "0x2229848", VA = "0x2229848")]
	private void OnShowArriveEndPointTipsChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CDFC")]
	[Address(RVA = "0x2229A74", Offset = "0x2229A74", VA = "0x2229A74")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CDFD")]
	[Address(RVA = "0x2229A7C", Offset = "0x2229A7C", VA = "0x2229A7C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
