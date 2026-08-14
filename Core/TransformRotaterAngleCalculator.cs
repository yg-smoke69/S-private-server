using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000806")]
internal interface TransformRotaterAngleCalculator
{
	[Token(Token = "0x600333F")]
	Vector3 CalculateAnglesInLocalSpace(Vector3 current, Vector3 target, float maxRad);
}
