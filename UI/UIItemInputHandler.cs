using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

[Token(Token = "0x2001FCB")]
public class UIItemInputHandler : MonoBehaviour
{
	[Token(Token = "0x2001FCC")]
	private enum MouseButton
	{
		[Token(Token = "0x400C777")]
		Left,
		[Token(Token = "0x400C778")]
		Right,
		[Token(Token = "0x400C779")]
		Middle,
		[Token(Token = "0x400C77A")]
		None
	}

	[Token(Token = "0x400C76D")]
	[FieldOffset(Offset = "0xC")]
	public float PanMovementSensitivity;

	[Token(Token = "0x400C76E")]
	[FieldOffset(Offset = "0x10")]
	public float RotateSensitivity;

	[Token(Token = "0x400C76F")]
	[FieldOffset(Offset = "0x14")]
	private float CurrentPanAngle;

	[Token(Token = "0x400C770")]
	[FieldOffset(Offset = "0x18")]
	private Vector2 lastTouchPos;

	[Token(Token = "0x400C771")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 tempLastTouchPos;

	[Token(Token = "0x400C772")]
	[FieldOffset(Offset = "0x28")]
	public bool InputEnable;

	[Token(Token = "0x400C773")]
	private const string TargetAreaName = "ItemRotateTouchArea";

	[Token(Token = "0x400C774")]
	[FieldOffset(Offset = "0x2C")]
	private UIItemRotateType m_CurrentRotateType;

	[Token(Token = "0x400C775")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_RefencePoint;

	[Token(Token = "0x6009EF8")]
	[Address(RVA = "0x14877A8", Offset = "0x14877A8", VA = "0x14877A8")]
	public UIItemInputHandler()
	{
	}

	[Token(Token = "0x6009EF9")]
	[Address(RVA = "0x1487884", Offset = "0x1487884", VA = "0x1487884")]
	private void Start()
	{
	}

	[Token(Token = "0x6009EFA")]
	[Address(RVA = "0x1487C14", Offset = "0x1487C14", VA = "0x1487C14")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009EFB")]
	[Address(RVA = "0x1487FA0", Offset = "0x1487FA0", VA = "0x1487FA0")]
	public void SetRotateType(UIItemRotateType type)
	{
	}

	[Token(Token = "0x6009EFC")]
	[Address(RVA = "0x1487FA8", Offset = "0x1487FA8", VA = "0x1487FA8")]
	public void SetRefencePoint(Vector3 point)
	{
	}

	[Token(Token = "0x6009EFD")]
	[Address(RVA = "0x1487FB4", Offset = "0x1487FB4", VA = "0x1487FB4")]
	public void SetLastTouchPos(object[] data)
	{
	}

	[Token(Token = "0x6009EFE")]
	[Address(RVA = "0x1487FD0", Offset = "0x1487FD0", VA = "0x1487FD0")]
	private void FingerSet(LeanFinger finger)
	{
	}

	[Token(Token = "0x6009EFF")]
	[Address(RVA = "0x1488470", Offset = "0x1488470", VA = "0x1488470")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x6009F00")]
	[Address(RVA = "0x14884D0", Offset = "0x14884D0", VA = "0x14884D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6009F01")]
	[Address(RVA = "0x148828C", Offset = "0x148828C", VA = "0x148828C")]
	private void RotateItemByOffset(float offsetpos)
	{
	}

	[Token(Token = "0x6009F02")]
	[Address(RVA = "0x1488110", Offset = "0x1488110", VA = "0x1488110")]
	public bool IsTargetArea(Vector2 screenPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x6009F03")]
	[Address(RVA = "0x14884D4", Offset = "0x14884D4", VA = "0x14884D4")]
	private void RotateItem(float angle)
	{
	}

	[Token(Token = "0x6009F04")]
	[Address(RVA = "0x1488368", Offset = "0x1488368", VA = "0x1488368")]
	private void RotatePointItem(Vector3 point, float angle)
	{
	}

	[Token(Token = "0x6009F05")]
	[Address(RVA = "0x14886D8", Offset = "0x14886D8", VA = "0x14886D8")]
	public void EnableInput(bool v)
	{
	}

	[Token(Token = "0x6009F06")]
	[Address(RVA = "0x14886E0", Offset = "0x14886E0", VA = "0x14886E0")]
	public void ResetPetInput()
	{
	}

	[Token(Token = "0x6009F07")]
	[Address(RVA = "0x14887E4", Offset = "0x14887E4", VA = "0x14887E4")]
	public bool CheckOnUIClick()
	{
		return default(bool);
	}
}
