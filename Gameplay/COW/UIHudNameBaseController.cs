using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027C8")]
public class UIHudNameBaseController : UIBaseController
{
	[Token(Token = "0x400F59E")]
	[FieldOffset(Offset = "0x28")]
	private FollowCamera m_FollowCamera;

	[Token(Token = "0x400F59F")]
	[FieldOffset(Offset = "0x2C")]
	protected Camera m_FollowCameraComponent;

	[Token(Token = "0x400F5A0")]
	[FieldOffset(Offset = "0x30")]
	protected OUTSCREEN_DIRCTION_TYPE m_dirctionType;

	[Token(Token = "0x400F5A1")]
	[FieldOffset(Offset = "0x34")]
	protected GameObject m_ArrowLeft;

	[Token(Token = "0x400F5A2")]
	[FieldOffset(Offset = "0x38")]
	protected GameObject m_ArrowUp;

	[Token(Token = "0x400F5A3")]
	[FieldOffset(Offset = "0x3C")]
	protected GameObject m_ArrowRight;

	[Token(Token = "0x400F5A4")]
	[FieldOffset(Offset = "0x40")]
	protected GameObject m_ArrowDown;

	[Token(Token = "0x400F5A5")]
	[FieldOffset(Offset = "0x44")]
	protected UILabel m_DistanceLabel;

	[Token(Token = "0x400F5A6")]
	[FieldOffset(Offset = "0x48")]
	protected int m_PrevDistance;

	[Token(Token = "0x400F5A7")]
	[FieldOffset(Offset = "0x4C")]
	private StringBuilder m_DistanceStr;

	[Token(Token = "0x600F623")]
	[Address(RVA = "0x1F4E190", Offset = "0x1F4E190", VA = "0x1F4E190")]
	public UIHudNameBaseController()
	{
	}

	[Token(Token = "0x600F624")]
	[Address(RVA = "0x1F4E214", Offset = "0x1F4E214", VA = "0x1F4E214", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F625")]
	[Address(RVA = "0x1F4E3DC", Offset = "0x1F4E3DC", VA = "0x1F4E3DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F626")]
	[Address(RVA = "0x1F4E518", Offset = "0x1F4E518", VA = "0x1F4E518", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F627")]
	[Address(RVA = "0x1F4E654", Offset = "0x1F4E654", VA = "0x1F4E654", Slot = "31")]
	protected virtual Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F628")]
	[Address(RVA = "0x1F4E728", Offset = "0x1F4E728", VA = "0x1F4E728", Slot = "32")]
	protected virtual bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F629")]
	[Address(RVA = "0x1F4E780", Offset = "0x1F4E780", VA = "0x1F4E780", Slot = "33")]
	protected virtual bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600F62A")]
	[Address(RVA = "0x1F4E7D8", Offset = "0x1F4E7D8", VA = "0x1F4E7D8", Slot = "34")]
	protected virtual bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600F62B")]
	[Address(RVA = "0x1F4E830", Offset = "0x1F4E830", VA = "0x1F4E830", Slot = "35")]
	protected virtual bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600F62C")]
	[Address(RVA = "0x1F4E888", Offset = "0x1F4E888", VA = "0x1F4E888", Slot = "36")]
	protected virtual void OnDistanceChanged(float distance)
	{
	}

	[Token(Token = "0x600F62D")]
	[Address(RVA = "0x1F4E8E4", Offset = "0x1F4E8E4", VA = "0x1F4E8E4", Slot = "37")]
	protected virtual bool NeedShowOutScreenAllow()
	{
		return default(bool);
	}

	[Token(Token = "0x600F62E")]
	[Address(RVA = "0x1F4E93C", Offset = "0x1F4E93C", VA = "0x1F4E93C", Slot = "38")]
	protected virtual bool KeepShowDownArrow()
	{
		return default(bool);
	}

	[Token(Token = "0x600F62F")]
	[Address(RVA = "0x1F4E994", Offset = "0x1F4E994", VA = "0x1F4E994", Slot = "39")]
	protected virtual void OnHudOutScreen(OUTSCREEN_DIRCTION_TYPE OutType)
	{
	}

	[Token(Token = "0x600F630")]
	[Address(RVA = "0x1F4EB7C", Offset = "0x1F4EB7C", VA = "0x1F4EB7C", Slot = "40")]
	protected virtual void LateUpdate()
	{
	}

	[Token(Token = "0x600F631")]
	[Address(RVA = "0x1F4F180", Offset = "0x1F4F180", VA = "0x1F4F180", Slot = "41")]
	protected virtual void UpdateNamePosition()
	{
	}

	[Token(Token = "0x600F632")]
	[Address(RVA = "0x1F4EF90", Offset = "0x1F4EF90", VA = "0x1F4EF90")]
	private void SetDistance(int distance)
	{
	}

	[Token(Token = "0x600F633")]
	[Address(RVA = "0x1F4FAE8", Offset = "0x1F4FAE8", VA = "0x1F4FAE8", Slot = "42")]
	protected virtual Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600F634")]
	[Address(RVA = "0x1F4FBBC", Offset = "0x1F4FBBC", VA = "0x1F4FBBC", Slot = "43")]
	protected virtual Vector3 ExtraScreenGap()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F635")]
	[Address(RVA = "0x1F4FC90", Offset = "0x1F4FC90", VA = "0x1F4FC90", Slot = "44")]
	protected virtual bool IsVisibleWithZoneType(int zonetype)
	{
		return default(bool);
	}

	[Token(Token = "0x600F636")]
	[Address(RVA = "0x1F4FCF4", Offset = "0x1F4FCF4", VA = "0x1F4FCF4", Slot = "45")]
	protected virtual void OnTrainingZoneChanged(object[] param)
	{
	}

	[Token(Token = "0x600F637")]
	[Address(RVA = "0x1F4FE38", Offset = "0x1F4FE38", VA = "0x1F4FE38")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F638")]
	[Address(RVA = "0x1F4FE40", Offset = "0x1F4FE40", VA = "0x1F4FE40")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600F639")]
	[Address(RVA = "0x1F4FE48", Offset = "0x1F4FE48", VA = "0x1F4FE48")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
