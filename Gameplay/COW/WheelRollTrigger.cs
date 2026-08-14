using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000748")]
public class WheelRollTrigger : MonoBehaviour
{
	[Token(Token = "0x4004CDB")]
	[FieldOffset(Offset = "0xC")]
	public EWheelRollTriggerType TriggerType;

	[Token(Token = "0x4004CDC")]
	[FieldOffset(Offset = "0x10")]
	private Vector3 Center;

	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x21BABE4", Offset = "0x21BABE4", VA = "0x21BABE4")]
	public WheelRollTrigger()
	{
	}

	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x21BABEC", Offset = "0x21BABEC", VA = "0x21BABEC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x21BAD30", Offset = "0x21BAD30", VA = "0x21BAD30")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0x21BB0BC", Offset = "0x21BB0BC", VA = "0x21BB0BC")]
	private void OnTriggerExit(Collider other)
	{
	}
}
