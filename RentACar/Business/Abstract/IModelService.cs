﻿namespace Business.Abstract;

public interface IModelService
{
    public GetModelListResponse GetList(GetModelListRequest request);
    public GetModelByIdResponse GetById(GetModelByIdRequest request);
    public AddModelResponse Add(AddModelRequest request);
    public UpdateModelResponse Update(UpdateModelRequest request);

    public DeleteModelResponse Delete(DeleteModelRequest request);
}

