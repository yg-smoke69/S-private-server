using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002714")]
public class UIHudControlPointPosMarkController : UIHudNameBaseController
{
	[Token(Token = "0x2002715")]
	public enum MarkType
	{
		[Token(Token = "0x400F12F")]
		EMarkType_Default,
		[Token(Token = "0x400F130")]
		EMarkType_GuildWar_Generator,
		[Token(Token = "0x400F131")]
		EMarkType_GuildWar_Warehouse
	}

	[Token(Token = "0x400F11E")]
	[FieldOffset(Offset = "0x50")]
	private UIHudControlPointPosMarkView m_View;

	[Token(Token = "0x400F11F")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_ControlPointPos;

	[Token(Token = "0x400F120")]
	[FieldOffset(Offset = "0x60")]
	private uint m_CurrentPointID;

	[Token(Token = "0x400F121")]
	[FieldOffset(Offset = "0x64")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F122")]
	private const int NO_OCCUPY_COLOR = 2130706517;

	[Token(Token = "0x400F123")]
	private const int LOCAL_OCCUPY_COLOR = 2131790519;

	[Token(Token = "0x400F124")]
	private const int OPP_OCCUPY_COLOR = 2145343516;

	[Token(Token = "0x400F125")]
	[FieldOffset(Offset = "0x68")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400F126")]
	[FieldOffset(Offset = "0x6C")]
	public bool m_NeedKeepInscreen;

	[Token(Token = "0x400F127")]
	[FieldOffset(Offset = "0x70")]
	public MeshRenderer m_TimeRender;

	[Token(Token = "0x400F128")]
	[FieldOffset(Offset = "0x74")]
	private ParticleSystem m_TimeUpParticle;

	[Token(Token = "0x400F129")]
	[FieldOffset(Offset = "0x78")]
	private bool m_TimeUpEffectPlayed;

	[Token(Token = "0x400F12A")]
	private const float TIME_EMPTY = -0.5f;

	[Token(Token = "0x400F12B")]
	private const float TIME_SPAN = 0.7f;

	[Token(Token = "0x400F12C")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_WarehosueHitDelayCallID;

	[Token(Token = "0x400F12D")]
	[FieldOffset(Offset = "0x80")]
	private MarkType m_MarkType;

	[Token(Token = "0x600ED7F")]
	[Address(RVA = "0x1365C5C", Offset = "0x1365C5C", VA = "0x1365C5C")]
	public UIHudControlPointPosMarkController()
	{
	}

	[Token(Token = "0x600ED80")]
	[Address(RVA = "0x1365D08", Offset = "0x1365D08", VA = "0x1365D08")]
	public void UpdateMarkType(MarkType markType)
	{
	}

	[Token(Token = "0x600ED81")]
	[Address(RVA = "0x1366044", Offset = "0x1366044", VA = "0x1366044")]
	private void SetSimpleUI()
	{
	}

	[Token(Token = "0x600ED82")]
	[Address(RVA = "0x13664CC", Offset = "0x13664CC", VA = "0x13664CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED83")]
	[Address(RVA = "0x1366570", Offset = "0x1366570", VA = "0x1366570", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED84")]
	[Address(RVA = "0x1366C08", Offset = "0x1366C08", VA = "0x1366C08", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600ED85")]
	[Address(RVA = "0x1366EE8", Offset = "0x1366EE8", VA = "0x1366EE8", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600ED86")]
	[Address(RVA = "0x13670C4", Offset = "0x13670C4", VA = "0x13670C4", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600ED87")]
	[Address(RVA = "0x1367130", Offset = "0x1367130", VA = "0x1367130", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600ED88")]
	[Address(RVA = "0x1367308", Offset = "0x1367308", VA = "0x1367308", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600ED89")]
	[Address(RVA = "0x1367360", Offset = "0x1367360", VA = "0x1367360")]
	private void OnMyWareHouseHit(object[] data)
	{
	}

	[Token(Token = "0x600ED8A")]
	[Address(RVA = "0x136750C", Offset = "0x136750C", VA = "0x136750C")]
	private void OnGuildWarFirstPickup(object[] data)
	{
	}

	[Token(Token = "0x600ED8B")]
	[Address(RVA = "0x136764C", Offset = "0x136764C", VA = "0x136764C")]
	private void OnMyWareHouseHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600ED8C")]
	[Address(RVA = "0x1367888", Offset = "0x1367888", VA = "0x1367888")]
	private void OnOccupateTeamChange(object[] data)
	{
	}

	[Token(Token = "0x600ED8D")]
	[Address(RVA = "0x1367CC4", Offset = "0x1367CC4", VA = "0x1367CC4")]
	public void InitControlPointPos(Vector3 pos)
	{
	}

	[Token(Token = "0x600ED8E")]
	[Address(RVA = "0x1366220", Offset = "0x1366220", VA = "0x1366220")]
	public void SetNormalStateIcon(string iconName)
	{
	}

	[Token(Token = "0x600ED8F")]
	[Address(RVA = "0x1367D60", Offset = "0x1367D60", VA = "0x1367D60")]
	private void Update()
	{
	}

	[Token(Token = "0x600ED90")]
	[Address(RVA = "0x1368010", Offset = "0x1368010", VA = "0x1368010")]
	private void OnControlPointChange(object[] data)
	{
	}

	[Token(Token = "0x600ED91")]
	[Address(RVA = "0x1366988", Offset = "0x1366988", VA = "0x1366988")]
	private void ClearHudShow()
	{
	}

	[Token(Token = "0x600ED92")]
	[Address(RVA = "0x13684EC", Offset = "0x13684EC", VA = "0x13684EC")]
	private void _003COnMyWareHouseHit_003Em__0()
	{
	}

	[Token(Token = "0x600ED93")]
	[Address(RVA = "0x1368530", Offset = "0x1368530", VA = "0x1368530")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ED94")]
	[Address(RVA = "0x1368538", Offset = "0x1368538", VA = "0x1368538")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600ED95")]
	[Address(RVA = "0x1368540", Offset = "0x1368540", VA = "0x1368540")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600ED96")]
	[Address(RVA = "0x1368554", Offset = "0x1368554", VA = "0x1368554")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600ED97")]
	[Address(RVA = "0x136855C", Offset = "0x136855C", VA = "0x136855C")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600ED98")]
	[Address(RVA = "0x1368570", Offset = "0x1368570", VA = "0x1368570")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}
}
