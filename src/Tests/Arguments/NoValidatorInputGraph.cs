﻿using GraphQL.Types;

public class NoValidatorInputGraph :
    InputObjectGraphType
{
    public NoValidatorInputGraph()
    {
        Field<StringGraphType>("content");
    }
}