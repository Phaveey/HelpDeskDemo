﻿namespace HelpDeskDemo.WebApi.Exceptions
{
    public class IdParametersBadRequestException : BadRequestException
    {
        public IdParametersBadRequestException() : base("Parameter id is null")
        {
        }
    }
}
