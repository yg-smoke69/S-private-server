using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002891")]
internal class UIHudTutorialTargetGuideController : UIBaseController
{
	[Token(Token = "0x400F9C0")]
	[FieldOffset(Offset = "0x28")]
	private readonly Color TARGETCOLOR;

	[Token(Token = "0x400F9C1")]
	[FieldOffset(Offset = "0x38")]
	private readonly int TARGETOFFSET;

	[Token(Token = "0x400F9C2")]
	[FieldOffset(Offset = "0x3C")]
	private UIHudTutorialTargetGuideView m_View;

	[Token(Token = "0x400F9C3")]
	[FieldOffset(Offset = "0x40")]
	private Camera m_FollowCamera;

	[Token(Token = "0x400F9C4")]
	[FieldOffset(Offset = "0x44")]
	private FollowCamera m_FollowCameraComponent;

	[Token(Token = "0x400F9C5")]
	[FieldOffset(Offset = "0x48")]
	private Camera m_UICamera;

	[Token(Token = "0x400F9C6")]
	[FieldOffset(Offset = "0x4C")]
	private UIForceTutorialGameScene m_InGameScene;

	[Token(Token = "0x400F9C7")]
	[FieldOffset(Offset = "0x50")]
	private int m_PrevDistance;

	[Token(Token = "0x400F9C8")]
	[FieldOffset(Offset = "0x54")]
	private StringBuilder m_Distance;

	[Token(Token = "0x400F9C9")]
	[FieldOffset(Offset = "0x58")]
	private IHAAMHPPLMG m_BindPlayer;

	[Token(Token = "0x400F9CA")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 m_BindTargetPos;

	[Token(Token = "0x400F9CB")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_IsTargetPlayer;

	[Token(Token = "0x400F9CC")]
	[FieldOffset(Offset = "0x7D")]
	private bool m_IsActivated;

	[Token(Token = "0x400F9CD")]
	[FieldOffset(Offset = "0x80")]
	private float m_ViewPortBoundary;

	[Token(Token = "0x600FEA6")]
	[Address(RVA = "0x1591530", Offset = "0x1591530", VA = "0x1591530")]
	public UIHudTutorialTargetGuideController()
	{
	}

	[Token(Token = "0x600FEA7")]
	[Address(RVA = "0x1591658", Offset = "0x1591658", VA = "0x1591658")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FEA8")]
	[Address(RVA = "0x1591700", Offset = "0x1591700", VA = "0x1591700", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FEA9")]
	[Address(RVA = "0x1591888", Offset = "0x1591888", VA = "0x1591888", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FEAA")]
	[Address(RVA = "0x1591C1C", Offset = "0x1591C1C", VA = "0x1591C1C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FEAB")]
	[Address(RVA = "0x15919B0", Offset = "0x15919B0", VA = "0x15919B0")]
	private void InitCamera()
	{
	}

	[Token(Token = "0x600FEAC")]
	[Address(RVA = "0x1591C80", Offset = "0x1591C80", VA = "0x1591C80")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600FEAD")]
	[Address(RVA = "0x1591D20", Offset = "0x1591D20", VA = "0x1591D20")]
	private Vector3 GetPosFromPlayer()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600FEAE")]
	[Address(RVA = "0x1591FD8", Offset = "0x1591FD8", VA = "0x1591FD8")]
	private void UpdateTargetPosition(Vector3 namePos)
	{
	}

	[Token(Token = "0x600FEAF")]
	[Address(RVA = "0x159250C", Offset = "0x159250C", VA = "0x159250C")]
	private void SetDistance(int distance)
	{
	}

	[Token(Token = "0x600FEB0")]
	[Address(RVA = "0x15926C4", Offset = "0x15926C4", VA = "0x15926C4")]
	public void BindPlayer(IHAAMHPPLMG pID)
	{
	}

	[Token(Token = "0x600FEB1")]
	[Address(RVA = "0x1592A70", Offset = "0x1592A70", VA = "0x1592A70")]
	public void UnbindPlayer()
	{
	}

	[Token(Token = "0x600FEB2")]
	[Address(RVA = "0x1592B78", Offset = "0x1592B78", VA = "0x1592B78")]
	public void BindPos(Vector3 pos)
	{
	}

	[Token(Token = "0x600FEB3")]
	[Address(RVA = "0x1592E7C", Offset = "0x1592E7C", VA = "0x1592E7C")]
	public void UnbindPos()
	{
	}

	[Token(Token = "0x600FEB4")]
	[Address(RVA = "0x1592EF0", Offset = "0x1592EF0", VA = "0x1592EF0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FEB5")]
	[Address(RVA = "0x1592EF8", Offset = "0x1592EF8", VA = "0x1592EF8")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FEB6")]
	[Address(RVA = "0x1592F00", Offset = "0x1592F00", VA = "0x1592F00")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
