using Il2CppDummyDll;
using UnityEngine;

namespace PrefabEvolution;

[Token(Token = "0x2003BAC")]
public class GameObjectWrapper
{
	[Token(Token = "0x401967C")]
	[FieldOffset(Offset = "0x8")]
	public GameObject target;

	[Token(Token = "0x170018BA")]
	public bool m_IsActive
	{
		[Token(Token = "0x6017CFF")]
		[Address(RVA = "0x1E2C928", Offset = "0x1E2C928", VA = "0x1E2C928")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017D00")]
		[Address(RVA = "0x1E2C954", Offset = "0x1E2C954", VA = "0x1E2C954")]
		set
		{
		}
	}

	[Token(Token = "0x6017CFE")]
	[Address(RVA = "0x1E2C4B0", Offset = "0x1E2C4B0", VA = "0x1E2C4B0")]
	public GameObjectWrapper(GameObject target)
	{
	}
}
