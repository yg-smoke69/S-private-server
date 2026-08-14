using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AAC")]
public class WeatherMaterialOverride : MonoBehaviour
{
	[Token(Token = "0x4005D57")]
	[FieldOffset(Offset = "0xC")]
	private Renderer cachedRenderer;

	[Token(Token = "0x4005D58")]
	[FieldOffset(Offset = "0x10")]
	public string weatherName;

	[Token(Token = "0x4005D59")]
	[FieldOffset(Offset = "0x14")]
	public Color[] colors;

	[Token(Token = "0x4005D5A")]
	[FieldOffset(Offset = "0x18")]
	public string[] colorNames;

	[Token(Token = "0x60051AB")]
	[Address(RVA = "0x2A6C03C", Offset = "0x2A6C03C", VA = "0x2A6C03C")]
	public WeatherMaterialOverride()
	{
	}

	[Token(Token = "0x60051AC")]
	[Address(RVA = "0x2A6C0A8", Offset = "0x2A6C0A8", VA = "0x2A6C0A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60051AD")]
	[Address(RVA = "0x2A6C110", Offset = "0x2A6C110", VA = "0x2A6C110")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60051AE")]
	[Address(RVA = "0x2A6C210", Offset = "0x2A6C210", VA = "0x2A6C210")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60051AF")]
	[Address(RVA = "0x2A6C310", Offset = "0x2A6C310", VA = "0x2A6C310")]
	private void OnWeatherChanged(string weatherName)
	{
	}

	[Token(Token = "0x60051B0")]
	[Address(RVA = "0x2A6C4F0", Offset = "0x2A6C4F0", VA = "0x2A6C4F0")]
	public void ReadProperties()
	{
	}

	[Token(Token = "0x60051B1")]
	[Address(RVA = "0x2A6C3B0", Offset = "0x2A6C3B0", VA = "0x2A6C3B0")]
	public void ApplyProperties()
	{
	}
}
