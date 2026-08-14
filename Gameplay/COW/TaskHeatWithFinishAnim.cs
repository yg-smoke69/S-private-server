using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AD0")]
public class TaskHeatWithFinishAnim : TaskHeat
{
	[Token(Token = "0x4018FDB")]
	[FieldOffset(Offset = "0x78")]
	public GameObject FinishTweenAnimObject;

	[Token(Token = "0x60174A8")]
	[Address(RVA = "0x2898934", Offset = "0x2898934", VA = "0x2898934")]
	public TaskHeatWithFinishAnim()
	{
	}

	[Token(Token = "0x60174A9")]
	[Address(RVA = "0x2898964", Offset = "0x2898964", VA = "0x2898964", Slot = "5")]
	public override void OnSuccess()
	{
	}

	[Token(Token = "0x60174AA")]
	[Address(RVA = "0x2898A90", Offset = "0x2898A90", VA = "0x2898A90")]
	public void _003C_003EiFixBaseProxy_OnSuccess()
	{
	}
}
