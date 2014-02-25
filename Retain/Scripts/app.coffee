jQuery ->
  $('.ui.sidebar').sidebar({ overlay: true })
  $('body').click (e) ->
    if $('.ui.sidebar').sidebar('is open')
      $('.ui.sidebar').sidebar('hide')
  $('.sidebar-toggle').click (e) ->
    e.preventDefault()
    e.stopPropagation()
    $('.ui.sidebar').sidebar('show')
  $('.ui.checkbox').checkbox()
  $('.ui.form').form()
