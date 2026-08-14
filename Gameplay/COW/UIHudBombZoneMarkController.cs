using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026F5")]
internal class UIHudBombZoneMarkController : UIHudNameBaseController
{
	[Token(Token = "0x400F090")]
	[FieldOffset(Offset = "0x50")]
	private UIHudBombZoneMarkView m_View;

	[Token(Token = "0x400F091")]
	[FieldOffset(Offset = "0x54")]
	private SafeZone.DOJILNNMFOL m_BombZoneInfo;

	[Token(Token = "0x400F092")]
	[FieldOffset(Offset = "0x58")]
	private bool m_StartProgressing;

	[Token(Token = "0x400F093")]
	[FieldOffset(Offset = "0x5C")]
	private float m_StartTime;

	[Token(Token = "0x400F094")]
	[FieldOffset(Offset = "0x60")]
	private float m_TotalTime;

	[Token(Token = "0x400F095")]
	[FieldOffset(Offset = "0x64")]
	private UISprite m_ProgressSprite;

	[Token(Token = "0x400F096")]
	[FieldOffset(Offset = "0x68")]
	private Color bombColor;

	[Token(Token = "0x170011B0")]
	public bool StartProgressing
	{
		[Token(Token = "0x600EC5B")]
		[Address(RVA = "0x1E13030", Offset = "0x1E13030", VA = "0x1E13030")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600EC5C")]
		[Address(RVA = "0x1E13088", Offset = "0x1E13088", VA = "0x1E13088")]
		set
		{
		}
	}

	[Token(Token = "0x170011B1")]
	public SafeZone.DOJILNNMFOL BombZoneInfo
	{
		[Token(Token = "0x600EC60")]
		[Address(RVA = "0x1E139A4", Offset = "0x1E139A4", VA = "0x1E139A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600EC61")]
		[Address(RVA = "0x1E139FC", Offset = "0x1E139FC", VA = "0x1E139FC")]
		set
		{
		}
	}

	[Token(Token = "0x600EC5A")]
	[Address(RVA = "0x1E12FC8", Offset = "0x1E12FC8", VA = "0x1E12FC8")]
	public UIHudBombZoneMarkController()
	{
	}

	[Token(Token = "0x600EC5D")]
	[Address(RVA = "0x1E130E8", Offset = "0x1E130E8", VA = "0x1E130E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EC5E")]
	[Address(RVA = "0x1E1318C", Offset = "0x1E1318C", VA = "0x1E1318C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EC5F")]
	[Address(RVA = "0x1E136D0", Offset = "0x1E136D0", VA = "0x1E136D0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600EC62")]
	[Address(RVA = "0x1E13B0C", Offset = "0x1E13B0C", VA = "0x1E13B0C", Slot = "40")]
	protected override void LateUpdate()
	{
	}

	[Token(Token = "0x600EC63")]
	[Address(RVA = "0x1E13E0C", Offset = "0x1E13E0C", VA = "0x1E13E0C", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EC64")]
	[Address(RVA = "0x1E13E64", Offset = "0x1E13E64", VA = "0x1E13E64", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EC65")]
	[Address(RVA = "0x1E13FFC", Offset = "0x1E13FFC", VA = "0x1E13FFC", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600EC66")]
	[Address(RVA = "0x1E14054", Offset = "0x1E14054", VA = "0x1E14054", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600EC67")]
	[Address(RVA = "0x1E14224", Offset = "0x1E14224", VA = "0x1E14224")]
	private void OnBombRoundChange(object[] data)
	{
	}

	[Token(Token = "0x600EC68")]
	[Address(RVA = "0x1E144FC", Offset = "0x1E144FC", VA = "0x1E144FC")]
	private void OnEnterBombArea(object[] data)
	{
	}

	[Token(Token = "0x600EC69")]
	[Address(RVA = "0x1E1464C", Offset = "0x1E1464C", VA = "0x1E1464C")]
	private void On3PPreparation(object[] data)
	{
	}

	[Token(Token = "0x600EC6A")]
	[Address(RVA = "0x1E14B28", Offset = "0x1E14B28", VA = "0x1E14B28")]
	private void OnBombSettled(object[] data)
	{
	}

	[Token(Token = "0x600EC6B")]
	[Address(RVA = "0x1E14E10", Offset = "0x1E14E10", VA = "0x1E14E10")]
	private void OnBombRemoved(object[] data)
	{
	}

	[Token(Token = "0x600EC6C")]
	[Address(RVA = "0x1E14338", Offset = "0x1E14338", VA = "0x1E14338")]
	private void SetBombArrowStatus(bool hasBomb)
	{
	}

	[Token(Token = "0x600EC6D")]
	[Address(RVA = "0x1E150C8", Offset = "0x1E150C8", VA = "0x1E150C8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EC6E")]
	[Address(RVA = "0x1E150D0", Offset = "0x1E150D0", VA = "0x1E150D0")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600EC6F")]
	[Address(RVA = "0x1E150D8", Offset = "0x1E150D8", VA = "0x1E150D8")]
	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}

	[Token(Token = "0x600EC70")]
	[Address(RVA = "0x1E150E0", Offset = "0x1E150E0", VA = "0x1E150E0")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EC71")]
	[Address(RVA = "0x1E150E8", Offset = "0x1E150E8", VA = "0x1E150E8")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EC72")]
	[Address(RVA = "0x1E150FC", Offset = "0x1E150FC", VA = "0x1E150FC")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600EC73")]
	[Address(RVA = "0x1E15104", Offset = "0x1E15104", VA = "0x1E15104")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}
}
