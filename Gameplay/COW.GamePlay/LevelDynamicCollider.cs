using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000615")]
public class LevelDynamicCollider : BaseLevelObject
{
	[Token(Token = "0x40045CA")]
	[FieldOffset(Offset = "0x74")]
	public bool isDynamic;

	[Token(Token = "0x40045CB")]
	[FieldOffset(Offset = "0x78")]
	public OJFMJOHPCNI colliderType;

	[Token(Token = "0x40045CC")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject hideModelOrVFX;

	[Token(Token = "0x40045CD")]
	[FieldOffset(Offset = "0x80")]
	private Collider[] PKHELAGKPDH;

	[Token(Token = "0x6002597")]
	[Address(RVA = "0x2719F98", Offset = "0x2719F98", VA = "0x2719F98")]
	public LevelDynamicCollider()
	{
	}

	[Token(Token = "0x6002598")]
	[Address(RVA = "0x2719FA0", Offset = "0x2719FA0", VA = "0x2719FA0", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002599")]
	[Address(RVA = "0x271A044", Offset = "0x271A044", VA = "0x271A044", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x600259A")]
	[Address(RVA = "0x271A120", Offset = "0x271A120", VA = "0x271A120", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x600259B")]
	[Address(RVA = "0x271A2AC", Offset = "0x271A2AC", VA = "0x271A2AC", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x600259C")]
	[Address(RVA = "0x271A304", Offset = "0x271A304", VA = "0x271A304")]
	private void BIGPKBNJAJI(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x600259D")]
	[Address(RVA = "0x271A388", Offset = "0x271A388", VA = "0x271A388")]
	public void SetIsEnabled(bool MCDIDHODHLN)
	{
	}

	[Token(Token = "0x600259E")]
	[Address(RVA = "0x271A52C", Offset = "0x271A52C", VA = "0x271A52C")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x600259F")]
	[Address(RVA = "0x271A534", Offset = "0x271A534", VA = "0x271A534")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60025A0")]
	[Address(RVA = "0x271A53C", Offset = "0x271A53C", VA = "0x271A53C")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}
}
