using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000475")]
public class TrainingShootGameRandomArea : MonoBehaviour
{
	[Token(Token = "0x4003D26")]
	[FieldOffset(Offset = "0x0")]
	public static TrainingShootGameRandomArea Instance;

	[Token(Token = "0x4003D27")]
	[FieldOffset(Offset = "0xC")]
	private Transform[] m_areas;

	[Token(Token = "0x170001FB")]
	public Transform[] areas
	{
		[Token(Token = "0x600166B")]
		[Address(RVA = "0x232D8BC", Offset = "0x232D8BC", VA = "0x232D8BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600166A")]
	[Address(RVA = "0x232D8B4", Offset = "0x232D8B4", VA = "0x232D8B4")]
	public TrainingShootGameRandomArea()
	{
	}

	[Token(Token = "0x600166C")]
	[Address(RVA = "0x232D914", Offset = "0x232D914", VA = "0x232D914")]
	private void Start()
	{
	}

	[Token(Token = "0x600166D")]
	[Address(RVA = "0x232DAD4", Offset = "0x232DAD4", VA = "0x232DAD4")]
	private void OnDestroy()
	{
	}
}
