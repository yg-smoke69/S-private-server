using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AAD")]
public class WeatherRelatedGameObject : MonoBehaviour
{
	[Token(Token = "0x4005D5B")]
	[FieldOffset(Offset = "0xC")]
	public string[] WeatherNames;

	[Token(Token = "0x4005D5C")]
	[FieldOffset(Offset = "0x10")]
	public bool[] ShowOrNot;

	[Token(Token = "0x60051B2")]
	[Address(RVA = "0x2A6C620", Offset = "0x2A6C620", VA = "0x2A6C620")]
	public WeatherRelatedGameObject()
	{
	}

	[Token(Token = "0x60051B3")]
	[Address(RVA = "0x2A6C628", Offset = "0x2A6C628", VA = "0x2A6C628")]
	private void Start()
	{
	}

	[Token(Token = "0x60051B4")]
	[Address(RVA = "0x2A6C904", Offset = "0x2A6C904", VA = "0x2A6C904")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60051B5")]
	[Address(RVA = "0x2A6C748", Offset = "0x2A6C748", VA = "0x2A6C748")]
	private void OnWeatherChanged(string weatherName)
	{
	}
}
