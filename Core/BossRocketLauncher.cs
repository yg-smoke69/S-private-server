using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B02")]
public class BossRocketLauncher : MonoBehaviour
{
	[Token(Token = "0x4005F47")]
	[FieldOffset(Offset = "0xC")]
	public List<Transform> AttackTargetPoint;

	[Token(Token = "0x60054AC")]
	[Address(RVA = "0x2ED2A48", Offset = "0x2ED2A48", VA = "0x2ED2A48")]
	public BossRocketLauncher()
	{
	}

	[Token(Token = "0x60054AD")]
	[Address(RVA = "0x2ED2AD4", Offset = "0x2ED2AD4", VA = "0x2ED2AD4")]
	public Transform ReturnTarget()
	{
		return null;
	}

	[Token(Token = "0x60054AE")]
	[Address(RVA = "0x2ED2B8C", Offset = "0x2ED2B8C", VA = "0x2ED2B8C")]
	private void OnDrawGizmosSelected()
	{
	}
}
