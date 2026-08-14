using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A7D")]
public class PVESceneStateManager : MonoBehaviour
{
	[Token(Token = "0x4005C68")]
	[FieldOffset(Offset = "0xC")]
	public List<PVESceneState> Scenestats;

	[Token(Token = "0x4005C69")]
	[FieldOffset(Offset = "0x10")]
	public EnvWeatherController WheatherManager;

	[Token(Token = "0x60050C0")]
	[Address(RVA = "0x1C795FC", Offset = "0x1C795FC", VA = "0x1C795FC")]
	public PVESceneStateManager()
	{
	}

	[Token(Token = "0x60050C1")]
	[Address(RVA = "0x1C79604", Offset = "0x1C79604", VA = "0x1C79604")]
	private void Start()
	{
	}

	[Token(Token = "0x60050C2")]
	[Address(RVA = "0x1C79750", Offset = "0x1C79750", VA = "0x1C79750")]
	public void EnterState(int index)
	{
	}
}
