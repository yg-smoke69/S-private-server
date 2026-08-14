using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D28")]
public class LastVehicleObject : MonoBehaviour
{
	[Token(Token = "0x40113D6")]
	private const float DELAY_SECOUNDS = 2f;

	[Token(Token = "0x40113D7")]
	[FieldOffset(Offset = "0xC")]
	private Vehicle m_BindVehicle;

	[Token(Token = "0x40113D8")]
	[FieldOffset(Offset = "0x10")]
	private uint m_HideDelayCallID;

	[Token(Token = "0x6012E1B")]
	[Address(RVA = "0x1EF71F0", Offset = "0x1EF71F0", VA = "0x1EF71F0")]
	public LastVehicleObject()
	{
	}

	[Token(Token = "0x6012E1C")]
	[Address(RVA = "0x1EF71F8", Offset = "0x1EF71F8", VA = "0x1EF71F8")]
	public void BindVehicleAndShow(uint vehicleObjID)
	{
	}

	[Token(Token = "0x6012E1D")]
	[Address(RVA = "0x1EF7878", Offset = "0x1EF7878", VA = "0x1EF7878")]
	public void HideObject(bool needDelay = false)
	{
	}

	[Token(Token = "0x6012E1E")]
	[Address(RVA = "0x1EF7A94", Offset = "0x1EF7A94", VA = "0x1EF7A94")]
	private void OnHide()
	{
	}

	[Token(Token = "0x6012E1F")]
	[Address(RVA = "0x1EF7BDC", Offset = "0x1EF7BDC", VA = "0x1EF7BDC")]
	public void Update()
	{
	}

	[Token(Token = "0x6012E20")]
	[Address(RVA = "0x1EF7528", Offset = "0x1EF7528", VA = "0x1EF7528")]
	private void UpdatePositionAndRotation()
	{
	}
}
