using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000C3B")]
public class UGCSoundEntity : MonoBehaviour
{
	[Token(Token = "0x40064EA")]
	[FieldOffset(Offset = "0xC")]
	private AudioResource m_EngineResource;

	[Token(Token = "0x40064EB")]
	[FieldOffset(Offset = "0x10")]
	private PresentSoundEntity m_entityComm;

	[Token(Token = "0x40064EC")]
	[FieldOffset(Offset = "0x14")]
	private string m_entityID;

	[Token(Token = "0x40064ED")]
	[FieldOffset(Offset = "0x18")]
	private string TrackEntityID;

	[Token(Token = "0x40064EE")]
	[FieldOffset(Offset = "0x1C")]
	public Transform TrackObject;

	[Token(Token = "0x6005D76")]
	[Address(RVA = "0x258CF04", Offset = "0x258CF04", VA = "0x258CF04")]
	public UGCSoundEntity()
	{
	}

	[Token(Token = "0x6005D77")]
	[Address(RVA = "0x258CF0C", Offset = "0x258CF0C", VA = "0x258CF0C")]
	private void OnFollowTargetChanged(string valueOld, string valueNew)
	{
	}

	[Token(Token = "0x6005D78")]
	[Address(RVA = "0x258D06C", Offset = "0x258D06C", VA = "0x258D06C")]
	public void OnSoundTypeChanged(string valueOld, string valueNew)
	{
	}

	[Token(Token = "0x6005D79")]
	[Address(RVA = "0x258D308", Offset = "0x258D308", VA = "0x258D308")]
	public static UGCSoundEntity Create(string entityID)
	{
		return null;
	}

	[Token(Token = "0x6005D7A")]
	[Address(RVA = "0x258D6D0", Offset = "0x258D6D0", VA = "0x258D6D0")]
	private void OnDestroy()
	{
	}
}
