using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFoo
{
}

public interface IBar
{
}

public class Foo : IFoo
{
}

public class Bar : IBar
{
}

public class FooBar : IFoo, IBar
{
}
